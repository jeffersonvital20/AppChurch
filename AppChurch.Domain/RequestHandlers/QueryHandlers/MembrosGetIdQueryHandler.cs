using AppChrch.Shared.ViewModel;
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
        private readonly IMapper _mapper;
        

        public MembrosGetIdQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<Result<MembrosViewModel>> Handle(MembrosGetByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
