using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Olamaz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriği Boş Olamaz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Resmi Boş Olamaz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen en fazla 150 karakter giriniz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen en az 5 karakter giriniz");
        }
    }
}
