using AutoMapper;
using SsttekAcademyBootcamp.Models.Repositories.Books;

namespace SsttekBootcampHomeWork.Views.Books;

public class BookDetailViewModel : Profile
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public string ISBN { get; set; } = default!;
    public string? Genre { get; set; }
    public string? Publisher { get; set; }
    public int PageCount { get; set; }
    public string Language { get; set; } = default!;
    public string Summary { get; set; } = default!;
    public int AvailableCopies { get; set; }
    public string? ImageUrl { get; set; }

    public BookDetailViewModel()
    {
        CreateMap<Book, BookDetailViewModel>().ReverseMap();
    }
}