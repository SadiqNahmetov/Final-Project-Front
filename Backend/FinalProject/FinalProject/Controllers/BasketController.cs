﻿using FinalProject.Data;
using FinalProject.Models;
using FinalProject.ViewModels.Basket;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Authorize]
    public class BasketController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _context;
        public BasketController(UserManager<AppUser> userManager, AppDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.GetUserAsync(User);

            if (user == null) return Unauthorized();
            var basket = await _context.Baskets
               .Include(m => m.BasketProducts)
               .ThenInclude(m => m.Product)
               .ThenInclude(m => m.Brand)
               .Include(m => m.BasketProducts)
               .ThenInclude(m => m.Product)
               .ThenInclude(m => m.ProductImages)
                .FirstOrDefaultAsync(m => m.AppUserId == user.Id);
           
              BasketIndexVM model = new BasketIndexVM();
         
              if (basket == null) return View(model);

            foreach (var dbBasketProduct in basket.BasketProducts)
            {
                BasketProductVM basketProduct = new BasketProductVM
                {
                    Id = dbBasketProduct.Id,
                    Name = dbBasketProduct.Product.Name,
                    Image = dbBasketProduct.Product.ProductImages.FirstOrDefault(m => m.IsMain)?.Image,
                    Brand = dbBasketProduct.Product.Brand,
                    Quantity = dbBasketProduct.Quantity,
                    DiscountPrice = dbBasketProduct.Product.DiscountPrice,
                    Price = dbBasketProduct.Product.Price,
                    Total = (dbBasketProduct.Product.Price - ((dbBasketProduct.Product.Price / 100)
                    * dbBasketProduct.Product.DiscountPrice)) * dbBasketProduct.Quantity

                };
                model.BasketProducts.Add(basketProduct);

            }

            return View(model);
        }





        [HttpPost]
        public async Task<IActionResult> AddBasket(BasketAddVM basketAddVM)
        {
            if (!ModelState.IsValid) return BadRequest(basketAddVM);

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            var product = await _context.Products.FindAsync(basketAddVM.Id);
            if (product == null) return NotFound();

            var basket = await _context.Baskets.FirstOrDefaultAsync(m => m.AppUserId == user.Id);
            if (basket == null)
            {
                basket = new Basket
                {
                    AppUserId = user.Id
                };
                await _context.Baskets.AddAsync(basket);

                await _context.SaveChangesAsync();
            }

            var basketProduct = await _context.BasketProducts
                .FirstOrDefaultAsync(bp => bp.ProductId == product.Id && bp.BasketId == basket.Id);

            if (basketProduct != null)
            {
                basketProduct.Quantity++;
            }
            else
            {
                basketProduct = new BasketProduct
                {
                    BasketId = basket.Id,
                    ProductId = product.Id,
                    Quantity = 1
                };
                await _context.BasketProducts.AddAsync(basketProduct);

            }

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return Unauthorized();

            var basketProduct = await _context.BasketProducts
                .FirstOrDefaultAsync(bp => bp.Id == id
                && bp.Basket.AppUserId == user.Id);

            if (basketProduct == null) return NotFound();

            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == basketProduct.ProductId);
            if (product == null) return NotFound();

            _context.BasketProducts.Remove(basketProduct);
            await _context.SaveChangesAsync();
            return Ok();
        }

      
    }
}
