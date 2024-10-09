using AutoMapper;
using SsttekAcademyBootcamp.Models.Repositories.Books;

namespace SsttekBootcampHomeWork.Views.Books;

public class BookViewModel : Profile
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public string ISBN { get; set; }
    
    public BookViewModel()
    {
        CreateMap<Book, BookViewModel>().ReverseMap();
    }
}