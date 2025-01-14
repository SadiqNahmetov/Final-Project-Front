﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ProductImage : BaseEntity
    {
        public string Image { get; set; }

        public bool IsMain { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
