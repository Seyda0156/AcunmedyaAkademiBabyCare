using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class TestimonialValidator:AbstractValidator<Testimonial>
    {
        public TestimonialValidator() 
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad/Soyad Boş Bırakılamaz");
            RuleFor(x => x.TimeUsed).NotEmpty().WithMessage("Kullanıcı Süresi Boş Bırakılamaz");
            RuleFor(x => x.Like).NotEmpty().WithMessage("Beğeni Boş Bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz");
        }
    }
}
