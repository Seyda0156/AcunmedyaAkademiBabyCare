using AcunmedyaAkademiBabyCare.Entities;
using FluentValidation;

namespace AcunmedyaAkademiBabyCare.Validations
{
    public class BranchValidator:AbstractValidator<Branch>
    {
        public BranchValidator() 
        {
            RuleFor(x => x.BranchName).NotEmpty().WithMessage("Branş Boş Bırakılamaz!!!!");
        }
    }
}
