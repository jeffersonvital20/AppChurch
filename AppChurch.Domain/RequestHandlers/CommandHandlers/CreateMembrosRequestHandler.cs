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

namespace AppChurch.Domain.RequestHandlers.CommandHandlers
{
    public sealed class CreateMembrosRequestHandler : IRequestHandler<CreateMembroRequest, Result<MembrosViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IMembroRepository _repository;

        public CreateMembrosRequestHandler(IMapper mapper, IMembroRepository repository)
        {
            this._mapper = mapper;
            this._repository = repository;
        }

        public async Task<Result<MembrosViewModel>> Handle(CreateMembroRequest command, CancellationToken cancellationToken)
        {
            //MembroModel result =  _repository.GetById(command._membro.id);

            //if (result != default(MembroModel))
            //    return Result.Error<MembrosViewModel>(new Exception("Entity already exists"));

            var entity = _mapper.Map<MembroModel>(command);
            await _repository.Create(entity).ConfigureAwait(false);

            return Result.Success(_mapper.Map<MembrosViewModel>( _repository.GetById(entity.Id)));
        }
    }
}
