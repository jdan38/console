using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.AspNetCore.Data;

namespace Warehouse.AspNetCore.Models
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly WarehouseDbContext _warehouseDbContext;

        public CategoryRepo(WarehouseDbContext warehouseDbContext)
        {
            _warehouseDbContext = warehouseDbContext;
        }

        public IEnumerable<Category> AllCategories => _warehouseDbContext.Categories;
    }
}
