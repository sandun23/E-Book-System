using E_Book_System.Repo;
using E_Book_System.Repo.impl;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Controllers
{
   
    [Authorize(Roles ="ADMIN")]
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IBookRepo _bookRepo;
        private readonly ICustomerRepo _customerRepo;
        private readonly IOrderRepo _orderRepo;



        public AdminController(ILogger<AdminController> logger, IBookRepo bookRepo, ICustomerRepo customerRepo,IOrderRepo orderRepo)
        {
            _logger = logger;
            _bookRepo = bookRepo;
            _customerRepo = customerRepo;
            _orderRepo = orderRepo;
        }


        // GET: AdminController1
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BookList()
        {
            var book = _bookRepo.GetAllBooks();
            return View(book);
        }
        
        public ActionResult BookAddNew()
        {
            return View();
        }
        

        public ActionResult OrderList()
        {
            var orders = _orderRepo.GetAllOrderDetails();
            return View(orders);
        }
        
        public ActionResult CustomerList()
        {
            var customer = _customerRepo.GetAllCustomers();
            return View(customer);
        }

        public ActionResult BookEditLoad(string BookID)
        {
            var book = _bookRepo.GetBook(BookID);

            return View(book);
        }


        // GET: AdminController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
