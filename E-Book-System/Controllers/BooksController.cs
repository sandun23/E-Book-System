using E_Book_System.Models;
using E_Book_System.Repo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace E_Book_System.Controllers
{
    public class BooksController : Controller
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookRepo _bookRepo;
        private readonly IWebHostEnvironment _hostEnvironment;


        public BooksController(ILogger<BooksController> logger, IBookRepo bookRepo, IWebHostEnvironment hostEnvironment)
        {
            _logger = logger;
            _bookRepo = bookRepo;
            _hostEnvironment = hostEnvironment;
        }

       

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public ActionResult CreateBooks()
        {

            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {

          

            Console.WriteLine(ModelState.IsValid);
            if (ModelState.IsValid)
            {

                //Save image to wwwroot/image
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(book.BookImageFile.FileName);
                string extension = Path.GetExtension(book.BookImageFile.FileName);
                book.BookImageFileName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRootPath + "/BooksImage/", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await book.BookImageFile.CopyToAsync(fileStream);
                }
        
                _bookRepo.AddBook(book);
                return RedirectToAction("BookList", "Admin");
            }
            return RedirectToAction("BookList", "Admin");
        }

        [HttpPost]
        // GET: BooksController/Edit/5
        public ActionResult Edit(Book book)
        {
            
            if (ModelState.IsValid)
            {
                _bookRepo.BookUpdate(book);
                return RedirectToAction("BookList", "Admin");
            }
            return RedirectToAction("BookList", "Admin");
        }

    
        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksController/Delete/5
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
