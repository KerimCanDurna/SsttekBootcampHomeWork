using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SsttekAcademyBootcamp.Models.Repositories.Books;
using SsttekAcademyBootcamp.Models.Services;
using SsttekBootcampHomeWork.Views.Books;

namespace SsttekAcademyHomeWork.Controllers
{
    public class BooksController(IBookService bookService, IMapper mapper) : Controller
    {
        

        public IActionResult Index()
        {
            var books = bookService.GetBooks();
            var bookViewModels = mapper.Map<List<BookViewModel>>(books);
            return View(bookViewModels);
        }

        public IActionResult Detail(int id)
        {
            var book = bookService.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            var bookDetailViewModel = mapper.Map<BookDetailViewModel>(book);
            return View(bookDetailViewModel);
        }
        
        [HttpGet]
        public IActionResult Add()
        {
            return View(new BookDetailViewModel());
        }

        [HttpPost]
        public IActionResult Add(BookDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = mapper.Map<Book>(model);
                bookService.CreateBook(book); // BookService'de ilgili metodu oluştur.
                return RedirectToAction("Index"); // Kitap listesine yönlendir.
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = bookService.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            var model = mapper.Map<BookDetailViewModel>(book);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(BookDetailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = mapper.Map<Book>(model);
                bookService.UpdateBook(book); // BookService'de ilgili metodu oluştur.
                return RedirectToAction("Index"); // Kitap listesine yönlendir.
            }
            return View(model);
        }
    }
}