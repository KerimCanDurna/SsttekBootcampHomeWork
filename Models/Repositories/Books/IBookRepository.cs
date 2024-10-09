namespace SsttekAcademyBootcamp.Models.Repositories.Books
{
    public interface IBookRepository
    {
        List<Book> GetBooks();

        Book GetBook(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);
    }
}