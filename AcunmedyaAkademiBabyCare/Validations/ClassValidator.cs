using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class ClassValidator:AbstractValidator<Class>
    {
        public ClassValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat Boş Bırakılamaz");
            RuleFor(x => x.StudentCount).NotEmpty().WithMessage("Öğrenci Sayısı Boş Bırakılamaz");
            RuleFor(x => x.LessonCount).NotEmpty().WithMessage("Ders Sayısı Boş Bırakılamaz");
            RuleFor(x => x.ClassTime).NotEmpty().WithMessage("Ders Saati Boş Bırakılamaz");
            RuleFor(x => x.TeamId).NotEmpty().WithMessage("Öğretmen Seçiniz");

        }
    }
}
