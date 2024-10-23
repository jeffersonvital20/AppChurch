using AppChrch.Shared.ViewModel;
using AppChurch.Domain.Model;
using AppChurch.Domain.Repositories.Interfaces;
using AppChurch.Domain.Request.Query;
using MediatR;
using OperationResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppChurch.Domain.RequestHandlers.QueryHandlers
{
    public class MembrosGetAllQueryHandler :  IRequestHandler<MembrosGetAllQuery, Result<List<MembroModel>>>
    {
        //private readonly IMapper _mapper;
        private readonly IMembroRepository _repository;


        public MembrosGetAllQueryHandler(IMembroRepository repository)
        {
            _repository = repository;
        }       

        public Task<Result<List<MembroModel>>> Handle(MembrosGetAllQuery request, CancellationToken cancellationToken)
        {
            List<MembroModel> result = _repository.GetAll().ToList();

            return Result.Success(result);

        }
    }
}
