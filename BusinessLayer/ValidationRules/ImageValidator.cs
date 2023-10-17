using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsiniz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen başlığı maks 20 karakter olarak tanımlayınız");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen başlığı min 5 karakter olarak tanımlayınız");
            RuleFor(x=>x.Description).MaximumLength(50).WithMessage("Lütfen açıklmayı maks 50 karakter olarak tanımlayınız");
            RuleFor(x=>x.Description).MinimumLength(20).WithMessage("Lütfen açıklmayı min 20 karakter olarak tanımlayınız");
        }
    }
}
