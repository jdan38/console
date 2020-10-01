﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.AspNetCore.Models
{
    public class Inventory
    {
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool FeaturedItem { get; set; }
        public decimal Amount { get; set; }
        public bool InStock { get; set; }
        //public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
