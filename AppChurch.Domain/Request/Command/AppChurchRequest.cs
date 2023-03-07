using AppChrch.Shared.ViewModel;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Request.Command
{
    public class AppChurchRequest : IRequest<Result<MembrosViewModel>>, IValidatable
    {
    }
}
