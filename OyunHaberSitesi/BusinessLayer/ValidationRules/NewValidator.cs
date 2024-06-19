using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class NewValidator : AbstractValidator<New>
    {
        public NewValidator() 
        {
            RuleFor(x => x.News_category).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            //RuleFor(x => x.News_summary).NotEmpty().WithMessage("Summary Alanını Boş Geçemezsiniz");
            //RuleFor(x => x.News_summary).MinimumLength(5).WithMessage("Summary Alanını Boş Geçemezsiniz");
            //RuleFor(x => x.News_summary).MinimumLength(1999).WithMessage("Summary Alanını Boş Geçemezsiniz");
            //RuleFor(x => x.News_content).NotEmpty().WithMessage("Haber Alanını Boş Geçemezsiniz");
            //RuleFor(x => x.News_content).MinimumLength(5).WithMessage("Haber Alanını Boş Geçemezsiniz");
            //RuleFor(x => x.News_content).MinimumLength(1999).WithMessage("Haber Alanını Boş Geçemezsiniz");
            //RuleFor(x => x.News_writer).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            //RuleFor(x => x.News_image).NotEmpty().WithMessage("Resim URL'sini Boş Geçemezsiniz");

        }
    }
}
