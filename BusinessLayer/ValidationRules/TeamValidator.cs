using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("Takım arkadaş ismini boş geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim yolu boş geçilemez");
            RuleFor(x => x.PersonName).MaximumLength(50).WithMessage("Lütfen Personel adını 50 karakterden fazla girmeyiniz");
            RuleFor(x => x.PersonName).MinimumLength(3).WithMessage("Lütfen Personel adını en az 3 karakter giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen Görev adını 50 karakterden fazla girmeyiniz");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Lütfen Görev adını en az 3 karakter giriniz");

        }
    }
}
