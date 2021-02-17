using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoodOrder.Models;

namespace FoodOrder.Controllers
{
    public class FoodsController : Controller
    {
        public IActionResult Random()
        {
            var food = new Food() { Name = "Fries" };
            return View(food);
        }
    }
}