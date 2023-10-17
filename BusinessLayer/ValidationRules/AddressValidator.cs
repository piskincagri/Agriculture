using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Adres bilgilerini boş geçemezsiniz.");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Adres bilgilerini boş geçemezsiniz.");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Adres bilgilerini boş geçemezsiniz.");
            RuleFor(x=>x.Mapinfo).NotEmpty().WithMessage("Harita bilgilerini boş geçemezsiniz.");
            RuleFor(x => x.Description1).MaximumLength(60).WithMessage("Adres bilgileri maks 10 karakter olarak tanımlayınız");
            RuleFor(x => x.Description2).MaximumLength(60).WithMessage("Adres bilgileri maks 10 karakter olarak tanımlayınız");
            RuleFor(x => x.Description3).MaximumLength(20).WithMessage("Adres bilgileri maks 8 karakter olarak tanımlayınız");
            RuleFor(x => x.Description1).MinimumLength(5).WithMessage("Lütfen açıklmayı min 20 karakter olarak tanımlayınız");
            RuleFor(x => x.Description2).MinimumLength(5).WithMessage("Lütfen açıklmayı min 20 karakter olarak tanımlayınız");
            RuleFor(x => x.Description3).MinimumLength(5).WithMessage("Lütfen açıklmayı min 20 karakter olarak tanımlayınız");


        }
    }
}
