using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidatior : AbstractValidator<Writer>
	{
        public WriterValidatior()
        {
            
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");

            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş olamaz");
            RuleFor(x => x.WriterPassword).Matches("[A-Z]").WithMessage("Şifre içinde en az 1 adet büyük harf olmak zorunda");
            RuleFor(x => x.WriterPassword).Matches("[0-9]").WithMessage("Şifre içinde en az 1 adet Sayı olmak zorunda");

			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş Geçilemez");
			RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En Az 2 karakter giriniz");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("Lütfen En fazla 30 karakter giriniz");
            
        }
    }
}
