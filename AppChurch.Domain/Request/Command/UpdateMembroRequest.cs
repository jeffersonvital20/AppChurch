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
    public class UpdateMembroRequest : IRequest<Result<UpdateMembrosViewModel>>, IValidatable
    {
        public UpdateMembrosViewModel _membro { get; set; }
        public UpdateMembroRequest(UpdateMembrosViewModel membro)
        {
            _membro = membro;
        }
    }
}
