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

        [HttpGet("getAll")]
        public Task<IActionResult> GetAll()
            => SendRequest(new MembrosGetAllQuery());

        [HttpPost("create")]
        public Task<IActionResult> Create([FromBody] MembrosViewModel membro)
            => SendRequest(new CreateMembroRequest(membro));

        [HttpPatch("update")]
        public Task<IActionResult> Update([FromBody] UpdateMembrosViewModel input)
            => SendRequest(new UpdateMembroRequest(input));



        [HttpDelete("delete")]
        public Task<IActionResult> Delete([FromBody] DeleteMembrosViewModel id)
            => SendRequest(new DeleteMembroRequest(id));
    }
}
