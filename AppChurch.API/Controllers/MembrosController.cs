using AppChrch.Shared.ViewModel;
using AppChurch.API.Controllers.Base;
using AppChurch.Domain.Request.Command;
using AppChurch.Domain.Request.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AppChurch.API.Controllers
{
    public class MembrosController : AppChurchControllerBase
    {
        public MembrosController(IMediator mediator): base(mediator)
        {}
        [HttpGet("getById")]
        public Task<IActionResult> GetById([FromQuery] Guid id) => SendRequest(new MembrosGetByIdQuery(id));
        
        [HttpPost("create")]
        public Task<IActionResult> Create([FromBody] MembrosViewModel membro)
            => SendRequest(new CreateMembroRequest(membro));
    }
}
