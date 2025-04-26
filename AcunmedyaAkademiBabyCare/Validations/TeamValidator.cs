using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class TeamValidator:AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad/Soyad Boş Bırakılamaz");
            RuleFor(x => x.NameSurname).MinimumLength(3).WithMessage("Lütfen Ad/Soyad Bilgilerini en az 3 karakter olarak giriniz.");
            RuleFor(x => x.NameSurname).MaximumLength(20).WithMessage("Lütfen Ad/Soyad Bilgilerini en fazla 20 karakter olarak giriniz.");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş Bilgisi Boş Bırakılamaz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Bilgisi Boş Bırakılamaz.");
            RuleFor(x => x.ImgUrl).NotEmpty().WithMessage("Resim Yolu Boş Bırakılamaz.");
            RuleFor(x => x.BranchId).NotEmpty().WithMessage("Lütfen kayıt için bir branş seçiniz.");
        }
    }
}
