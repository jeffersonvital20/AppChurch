using AppChrch.Shared.ViewModel;
using AppChurch.Domain.Model;
using AppChurch.Domain.Validation;
using MediatR;
using OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.Request.Query
{
    public class MembrosGetAllQuery : IRequest<Result<List<MembroModel>>>, IValidatable
    {
    }
}
