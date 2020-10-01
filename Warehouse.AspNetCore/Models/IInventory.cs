using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.AspNetCore.Models
{
    public interface IInventory
    {
        IEnumerable<Inventory> AllInventories { get; }

        IEnumerable<Inventory> FeaturedItem { get; }

        Inventory GetInventoryById(int ItemId); 
    }
}
