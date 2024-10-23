using AppChrch.Shared.ViewModel;
using AppChurch.Domain.Model;
using AppChurch.Domain.Repositories.Interfaces;
using AppChurch.Domain.Request.Query;
using AutoMapper;
using MediatR;
using OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.RequestHandlers.QueryHandlers
{
    public class MembrosGetIdQueryHandler : IRequestHandler<MembrosGetByIdQuery, Result<MembrosViewModel>>
    {
        //private readonly IMapper _mapper;
        private readonly IMembroRepository _repository;


        public MembrosGetIdQueryHandler(IMembroRepository repository)
        {
            _repository = repository;
        }

        public Task<Result<MembrosViewModel>> Handle(MembrosGetByIdQuery request, CancellationToken cancellationToken)
        {
            MembroModel result = _repository.GetById(request.Id);
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
