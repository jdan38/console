using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warehouse.AspNetCore.Models;
using Warehouse.AspNetCore.ViewModels;

namespace Warehouse.AspNetCore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IInventory _inventoryItemRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IInventory inventoryItemRepo, ShoppingCart shoppingCart)
        {
            _inventoryItemRepo = inventoryItemRepo;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.  ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int ItemId)
        {
            var selectedInventory = _inventoryItemRepo.AllInventories.FirstOrDefault(p => p.ItemId == ItemId);

            if (selectedInventory != null)
            {
                _shoppingCart.AddToCart(selectedInventory, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int ItemId)
        {
            var selectedInventory = _inventoryItemRepo.AllInventories.FirstOrDefault(p => p.ItemId == ItemId);

            if (selectedInventory != null)
            {
                _shoppingCart.RemoveFromCart(selectedInventory);
            }
            return RedirectToAction("Index");
        }
    }
}
