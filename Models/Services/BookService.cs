using SsttekAcademyBootcamp.Models.Repositories.Books;

namespace SsttekAcademyBootcamp.Models.Services
{
    public class Bookservices (IBookRepository bookRepository) : IBookService
    {
        
        public List<Book> GetBooks()
        {
            return bookRepository.GetBooks();
        }

        public Book GetBook(int id)
        {
            return bookRepository.GetBook(id);
        }
    }
}