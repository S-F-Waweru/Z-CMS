using MediatR;
using Microsoft.AspNetCore.Mvc;
using Zeira.Application.Features.Members.Queries.GetMembers;
using Zeira.Application.Members.Commands.CreateMember;
using Zeira.Application.Members.Commands.DeleteMember;
using Zeira.Domain.Enums;

namespace Zeira.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MembersController : ControllerBase
{
    private readonly IMediator _mediator;

    public MembersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET api/members
    [HttpGet]
    [ProducesResponseType(typeof(MembersVm), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10, CancellationToken cancellationToken = default)
    {
        var result = await _mediator.Send(new GetMembersQuery(page, pageSize), cancellationToken);
        return Ok(result);
    }

    // POST api/members
    [HttpPost]
    [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] CreateMemberCommand command, CancellationToken cancellationToken)
    {
        var id = await _mediator.Send(command, cancellationToken);
        return CreatedAtAction(nameof(GetAll), new { id }, id);
    }

    // PUT api/members/5
    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateMemberRequest request, CancellationToken cancellationToken)
    {
        await _mediator.Send(new UpdateMemberCommand(id, request.FullName, request.Email, request.PhoneNumber, request.Role, request.Status, request.JoinDate), cancellationToken);
        return NoContent();
    }

    // DELETE api/members/5
    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
    {
        await _mediator.Send(new DeleteMemberCommand(id), cancellationToken);
        return NoContent();
    }
}

public record UpdateMemberRequest(
    string FullName,
    string Email,
    string PhoneNumber,
    MemberRole Role,
    MemberStatus Status,
    DateOnly JoinDate
);
