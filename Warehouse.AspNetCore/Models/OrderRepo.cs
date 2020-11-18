using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Warehouse.AspNetCore.Data;

namespace Warehouse.AspNetCore.Models
{
    public class OrderRepo : IOrderRepo
    {
        private readonly WarehouseDbContext _warehouseDbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepo(WarehouseDbContext warehouseDbContext, ShoppingCart shoppingCart)
        {
            _warehouseDbContext = warehouseDbContext;
            _shoppingCart = shoppingCart;
        }
    
    
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;
            order.OrderTotal = (int)_shoppingCart.GetShoppingCartTotal();

            order.OrderDetails = new List<OrderDetail>();
            //adding the order with its details

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    ItemId = shoppingCartItem.Inventory.ItemId,
                    Price = shoppingCartItem.Inventory.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _warehouseDbContext.Orders.Add(order);

            _warehouseDbContext.SaveChanges();
        }
    }

}
