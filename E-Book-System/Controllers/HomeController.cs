using E_Book_System.Models;
using E_Book_System.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookRepo _bookRepo;

        public HomeController(ILogger<HomeController> logger, IBookRepo bookRepo)
        {
            _logger = logger;
            _bookRepo = bookRepo;
        }

        public IActionResult Index()
        {
            var allBooks = _bookRepo.GetHomePageBooks();

            return View(allBooks);
        }

        public IActionResult ProdutView()
        {
            return View();
        }
        public IActionResult ShopView()
        {
            var allBooks = _bookRepo.GetAllBooks();

            return View(allBooks);
        }
         public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        } 
        
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
