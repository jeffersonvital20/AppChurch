using AppChrch.Shared.ViewModel;
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
    public class MembrosGetByIdQuery : IRequest<Result<MembrosViewModel>>, IValidatable
    {
        public Guid Id { get; set; }
        public MembrosGetByIdQuery(Guid id)
        => Id= id;
    }
}
