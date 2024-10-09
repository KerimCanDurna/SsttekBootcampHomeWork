using FluentValidation;

namespace SsttekBootcampHomeWork.Views.Books;

public class BookDetailViewModelValidator : AbstractValidator<BookDetailViewModel>
{
    public BookDetailViewModelValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Kitap adı boş olamaz.")
            .Length(1, 200).WithMessage("Kitap adı en az 1, en fazla 200 karakter olmalıdır.");

        RuleFor(x => x.Author)
            .NotEmpty().WithMessage("Yazar adı boş olamaz.")
            .Length(1, 100).WithMessage("Yazar adı en az 1, en fazla 100 karakter olmalıdır.");

        RuleFor(x => x.PublicationYear)
            .GreaterThan(0).WithMessage("Yayın yılı geçerli bir yıl olmalıdır.");

        RuleFor(x => x.ISBN)
            .NotEmpty().WithMessage("ISBN boş olamaz.")
            .Length(10, 13).WithMessage("ISBN 10 veya 13 karakter uzunluğunda olmalıdır.");

        RuleFor(x => x.PageCount)
            .GreaterThan(0).WithMessage("Sayfa sayısı 0'dan büyük olmalıdır.");

        RuleFor(x => x.Language)
            .NotEmpty().WithMessage("Dil bilgisi boş olamaz.");

        RuleFor(x => x.AvailableCopies)
            .GreaterThanOrEqualTo(0).WithMessage("Mevcut kopya sayısı 0 veya daha fazla olmalıdır.");
    }
}