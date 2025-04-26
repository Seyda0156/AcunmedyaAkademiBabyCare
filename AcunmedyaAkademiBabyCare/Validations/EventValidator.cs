using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class EventValidator:AbstractValidator<Event>
    {
        public EventValidator() 
        {
            RuleFor(x => x.EventName).NotEmpty().WithMessage("Etkinlik Adı Boş Bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz");
            RuleFor(x => x.Time).NotEmpty().WithMessage("Saat Boş Bırakılamaz");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Boş Bırakılamaz");

        }
    }
}
