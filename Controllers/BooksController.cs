using Microsoft.AspNetCore.Mvc;
using SsttekAcademyBootcamp.Models.Services;

namespace SsttekAcademyHomeWork.Controllers
{
    public class BooksController(IBookService bookService) : Controller
    {
        

        public IActionResult Index()
        {
            return View(bookService.GetBooks());
        }

        public IActionResult Detail(int id)
        {
            return View(bookService.GetBook(id));
        }
    }
}