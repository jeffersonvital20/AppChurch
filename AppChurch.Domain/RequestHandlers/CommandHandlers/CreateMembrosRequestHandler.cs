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
        //private readonly IMapper _mapper;
        private readonly IMembroRepository _repository;

        public CreateMembrosRequestHandler( IMembroRepository repository)
        {
            //this._mapper = mapper;
            this._repository = repository;
        }

        public async Task<Result<MembrosViewModel>> Handle(CreateMembroRequest command, CancellationToken cancellationToken)
        {
            //var entity = _mapper.Map<MembroModel>(command);
            MembroModel entity = new MembroModel()
            {
                Nome = command._membro.Nome,
                Idade = command._membro.Idade,
                sexo = command._membro.sexo,
                DataBatismo = command._membro.DataBatismo,
                DataConversao = command._membro.DataConversao,
                DataNascimento = command._membro.DataNascimento,
                Dizimo = new DizimoModel(),
                Endereco = new EnderecoModel()
               
            };
            await _repository.Create(entity).ConfigureAwait(false);

            MembroModel result = _repository.GetById(entity.Id);
            MembrosViewModel retorno = new MembrosViewModel()
            {
                Nome = result.Nome,
                Idade = result.Idade,
                sexo = result.sexo,
                DataBatismo = result.DataBatismo,
                DataConversao = result.DataConversao,
                DataNascimento = result.DataNascimento
            };
            return Result.Success(retorno);
        }
    }
}
