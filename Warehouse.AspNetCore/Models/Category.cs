using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.AspNetCore.Models
{

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
       
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public List<Inventory> Inventories { get; set; }
    }
}
