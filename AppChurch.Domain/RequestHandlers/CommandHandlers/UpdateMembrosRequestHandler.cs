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
    public sealed class UpdateMembrosRequestHandler : IRequestHandler<UpdateMembroRequest, Result<bool>>
    {
        //private readonly IMapper _mapper;
        private readonly IMembroRepository _repository;

        public UpdateMembrosRequestHandler( IMembroRepository repository)
        {
            //this._mapper = mapper;
            this._repository = repository;
        }       

        public async Task<Result<bool>> Handle(UpdateMembroRequest request, CancellationToken cancellationToken)
        {
            var UpdateMembro = _repository.GetById(request._membro.Id);
            UpdateMembro.Nome = request._membro.Nome;
            UpdateMembro.Idade = request._membro.Idade;
            UpdateMembro.sexo = request._membro.sexo;
            UpdateMembro.DataBatismo = request._membro.DataBatismo;
            UpdateMembro.DataConversao = request._membro.DataConversao;
            UpdateMembro.DataNascimento = request._membro.DataNascimento;
            //UpdateMembro.Dizimo = request._membro
            //UpdateMembro.Endereco = new EnderecoModel()

            _repository.Update(UpdateMembro);

            return true;
        }
    }
}
