using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık Yazınız!!!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama Yazınız!!!");
        }
    }
}
