﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShop.Models;
using BethanysPieShop.Model; 
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository; 
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart) 
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart; 
        }

        //GET: /<controller>/ 

        public IActionResult Checkout() 
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0) 
            {
                ModelState.AddModelError("", "Your cart is empty, add some pies first"); 
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete"); 
            }
            return View(order); 
        }
    }
}
