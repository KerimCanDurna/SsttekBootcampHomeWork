using SsttekAcademyBootcamp.Models.Repositories.Books;

namespace SsttekAcademyBootcamp.Models.Services
{
    public interface IBookService
    {
        List<Book> GetBooks();

        Book GetBook(int id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}