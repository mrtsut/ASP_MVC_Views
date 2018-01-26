﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private List<string> Cheeses = new List<string>();   // static - available to any code in the class

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            ViewBag.cheeses = Cheeses;   //Object to pass between controller and view

            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult NewCheese(string name)
        {
            // Add the new chese to my existing cheeses
            Cheeses.Add(name);


            return Redirect("/Cheese");

        }
    }
}
