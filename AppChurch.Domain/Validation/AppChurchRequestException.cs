using AppChurch.Domain.Request.Command;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Validation
{
    public class AppChurchRequestException : AbstractValidator<AppChurchRequest>
    {
        public AppChurchRequestException()
        {
            RuleFor(p => p).NotNull().WithMessage("{PropertyName must not be null}");

            //When(p => p != null, () =>
            //{
            //    RuleFor(p => p.nome)
            //    .NotEmpty().WithMessage("")
            //    .NotNull().WithMessage("");
            //});
        }
    }
}
