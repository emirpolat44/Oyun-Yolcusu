using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {
            RuleFor(x => x.Com_text).NotEmpty().WithMessage("Yorumu Boş Geçemezsiniz");
            //RuleFor(x => x.News_desc).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsiniz");
            //RuleFor(x => x.News_category).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            //RuleFor(x => x.News_category).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");

        }
    }
}
