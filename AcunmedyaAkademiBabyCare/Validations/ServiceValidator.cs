using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class ServiceValidator:AbstractValidator<Service>
    {
        public ServiceValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Boş Bırakılamaz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Boş Bırakılamaz");
            RuleFor(x => x.IconUrl).NotEmpty().WithMessage("İkon Giriniz");
        }
    }
}
