using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.AspNetCore.Data;

namespace Warehouse.AspNetCore.Models
{
    public class ShoppingCart
    {
        private readonly WarehouseDbContext _warehouseDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(WarehouseDbContext warehouseDbContext)
        {
            _warehouseDbContext = warehouseDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<WarehouseDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Inventory inventory, int amount)
        {
            var shoppingCartItem =
                    _warehouseDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Inventory.ItemId == inventory.ItemId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Inventory = inventory,
                    Amount = 1
                };

                _warehouseDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _warehouseDbContext.SaveChanges();
        }

        public int RemoveFromCart(Inventory inventory)
        {
            var shoppingCartItem =
                    _warehouseDbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Inventory.ItemId == inventory.ItemId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _warehouseDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _warehouseDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _warehouseDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Inventory)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _warehouseDbContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _warehouseDbContext.ShoppingCartItems.RemoveRange(cartItems);

            _warehouseDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _warehouseDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Inventory.Price * c.Amount).Sum();
            return total;
        }
    }
}
