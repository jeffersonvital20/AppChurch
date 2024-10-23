using AppChrch.Shared.ViewModel;
using AppChurch.Domain.Model;
using AppChurch.Domain.Repositories.Interfaces;
using AppChurch.Domain.Request.Command;
using AutoMapper;
using MediatR;
using OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AppChurch.Domain.RequestHandlers.CommandHandlers
{
    public sealed class DeleteMembrosRequestHandler : IRequestHandler<DeleteMembroRequest, Result<bool>>
    {
        //private readonly IMapper _mapper;
        private readonly IMembroRepository _repository;

        public DeleteMembrosRequestHandler( IMembroRepository repository)
        {
            //this._mapper = mapper;
            this._repository = repository;
        }       

        public async Task<Result<bool>> Handle(DeleteMembroRequest request, CancellationToken cancellationToken)
        {
            var DeleteMembro =  _repository.GetById(request._viewModel.Id);
            _repository.Delete(DeleteMembro);
            return true;
        }
    }
}
