using BestOnlineBookStore.Models;
using BestOnlineBookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using System.Diagnostics;

namespace BestOnlineBookStore.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepo repo;
        public HomeController(IBookstoreRepo temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var Blah = new BookViewModel
            {
                Books = repo.Books
                    .OrderBy(x => x.BookId)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = repo.Books.Count()
                }
            };

                return View(Blah);

        }
    }

}