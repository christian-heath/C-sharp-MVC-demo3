using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using fun.Models;

namespace fun.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet("")]
        public IActionResult Index()
        {
            string[] longtext = new string[]
            {
                "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam cursus, magna feugiat dapibus hendrerit, mi leo dapibus enim, vitae pretium nisi libero vitae quam. Aenean nec feugiat turpis, et commodo justo. Sed magna mi, imperdiet nec euismod vitae, suscipit ornare mauris. Donec quis felis sed sapien euismod dapibus semper aliquam orci. Nunc id hendrerit justo. Suspendisse mollis posuere turpis. Aenean tincidunt iaculis lacus, eget posuere nulla. Sed lorem purus, consequat sollicitudin sapien id, dictum mollis libero."
            };
            return View(longtext);
        }

        [HttpGet("numbers")]
        public IActionResult numbers()
        {
            int[] numbers = new int[]
            {
                1,2,3,10,43,5
            };
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult users()
        {
            string[] users = new string[]
            {
                "Bob", "Bill", "Phill", "Paul", "Charles"
            };
            return View(users);
        }

        [HttpGet("user")]
        public IActionResult user()
        {
            User user1 = new User()
            {
                FirstName = "Bob",
                LastName = "Willis"
            };
            return View(user1);
        }
    }
}
