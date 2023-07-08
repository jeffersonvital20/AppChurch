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

namespace AppChurch.Domain.Request.Command
{
    public class CreateMembroRequest : IRequest<Result<MembrosViewModel>>, IValidatable
    {
        public MembrosViewModel _membro { get; set; }
        public CreateMembroRequest(MembrosViewModel membro)
        {
            _membro = membro;
        }
    }
}
