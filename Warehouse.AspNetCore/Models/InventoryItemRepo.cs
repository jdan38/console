using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.AspNetCore.Data;

namespace Warehouse.AspNetCore.Models
{
    public class InventoryItemRepo : IInventory
    {
        private readonly WarehouseDbContext _warehouseDbContext;

        public InventoryItemRepo(WarehouseDbContext warehouseDbContext)
        {
            _warehouseDbContext = warehouseDbContext;
        }

        public IEnumerable<Inventory> AllInventories
        {

            get
            {
                return _warehouseDbContext.Inventories.Include(c => c.Category);
            }
        }

        public IEnumerable<Inventory> FeaturedItem
        {

            get
            {
                return _warehouseDbContext.Inventories.Include(c => c.Category).Where(i => i .FeaturedItem);
            }
        }

        public Inventory GetInventoryById(int itemId)
        {
            return _warehouseDbContext.Inventories.FirstOrDefault(p => p.ItemId == itemId);
        }

    }
}
 