using SsttekAcademyBootcamp.Models.Repositories.Books;

namespace SsttekAcademyHomeWork.Models.Repositories.Books
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>
    {
        new Book
        {
            Id = 1,
            Title = "Sefiller",
            Author = "Victor Hugo",
            PublicationYear = 1862,
            ISBN = "9786053325921",
            Genre = "Roman",
            Publisher = "İş Bankası Kültür Yayınları",
            PageCount = 1665,
            Language = "Türkçe",
            Summary = "Fransız devriminin ardından sosyal adaletsizlikleri anlatan bir başyapıt.",
            AvailableCopies = 3,
            ImageUrl = "https://example.com/sefiller.jpg"
        },
        new Book
        {
            Id = 2,
            Title = "1984",
            Author = "George Orwell",
            PublicationYear = 1949,
            ISBN = "9789754589021",
            Genre = "Distopya",
            Publisher = "Can Yayınları",
            PageCount = 352,
            Language = "Türkçe",
            Summary = "Baskıcı bir rejim altında insanın özgürlüğünü sorgulayan bir roman.",
            AvailableCopies = 5,
            ImageUrl = "https://example.com/1984.jpg"
        },
        new Book
        {
            Id = 3,
            Title = "Suç ve Ceza",
            Author = "Fyodor Dostoyevski",
            PublicationYear = 1866,
            ISBN = "9786053325709",
            Genre = "Klasik",
            Publisher = "İş Bankası Kültür Yayınları",
            PageCount = 704,
            Language = "Türkçe",
            Summary = "Bir cinayet üzerinden insan ruhunun derinliklerine inen bir eser.",
            AvailableCopies = 4,
            ImageUrl = "https://example.com/sucveceza.jpg"
        },
        new Book
        {
            Id = 4,
            Title = "Beyaz Zambaklar Ülkesinde",
            Author = "Grigory Petrov",
            PublicationYear = 1923,
            ISBN = "9789752630077",
            Genre = "Klasik",
            Publisher = "İnsan Yayınları",
            PageCount = 180,
            Language = "Türkçe",
            Summary = "Finlandiya’nın sosyal ve kültürel reform sürecini anlatan bir eser.",
            AvailableCopies = 2,
            ImageUrl = "https://example.com/beyazzambaklar.jpg"
        },
        new Book
        {
            Id = 5,
            Title = "Küçük Prens",
            Author = "Antoine de Saint-Exupéry",
            PublicationYear = 1943,
            ISBN = "9786053601988",
            Genre = "Çocuk Kitapları",
            Publisher = "Mavi Bulut Yayıncılık",
            PageCount = 112,
            Language = "Türkçe",
            Summary = "Bir çocuğun gözünden hayata dair derin anlamlar içeren bir hikaye.",
            AvailableCopies = 10,
            ImageUrl = "https://example.com/kucukprens.jpg"
        },
        new Book
        {
            Id = 6,
            Title = "Dönüşüm",
            Author = "Franz Kafka",
            PublicationYear = 1915,
            ISBN = "9786053329059",
            Genre = "Klasik",
            Publisher = "İş Bankası Kültür Yayınları",
            PageCount = 104,
            Language = "Türkçe",
            Summary = "Bir sabah uyandığında dev bir böceğe dönüşen Gregor Samsa'nın hikayesi.",
            AvailableCopies = 7,
            ImageUrl = "https://example.com/donusum.jpg"
        }
    };


        public List<Book> GetBooks()
        {
            return books;
        }

        public Book GetBook(int id) => books.FirstOrDefault(b => b.Id.Equals(id));
        public void AddBook(Book book)
        {
            book.Id = books.Max(b => b.Id) + 1;
            books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var existingBook = GetBook(book.Id);
            if (existingBook is not null)
            {
                existingBook.Title = book.Title;
                existingBook.Author = book.Author;
                existingBook.PublicationYear = book.PublicationYear;
                existingBook.ISBN = book.ISBN;
                existingBook.Genre = book.Genre;
                existingBook.Publisher = book.Publisher;
                existingBook.PageCount = book.PageCount;
                existingBook.Language = book.Language;
                existingBook.Summary = book.Summary;
                existingBook.AvailableCopies = book.AvailableCopies;
            }
        }

        public void DeleteBook(int id) => books.Remove(GetBook(id));
    }
}