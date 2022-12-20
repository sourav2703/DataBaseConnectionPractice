using DB_And_Table_Creation.BookRepo;
using DB_And_Table_Creation.Data;
using DB_And_Table_Creation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DB_And_Table_Creation.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly BookRepositry _bookRepositry = null;
        public HomeController(BookRepositry bookRepositry)
        {
            _bookRepositry = bookRepositry;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddBook()
        {
            return View();
        }
        public ViewResult AddBook_Post( BookModel model )
        {
            _bookRepositry.AddNewBook(model);

            return View();
        }
    }
}
