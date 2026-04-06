using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Commands.UpdateMember;

public record UpdateMemberCommand : IRequest<bool>
{
}

public class UpdateMemberCommandValidator : AbstractValidator<UpdateMemberCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateMemberCommandValidator"/> class.
    /// </summary>
    /// <remarks>
    /// No validation rules are configured currently.
    /// </remarks>
    public UpdateMemberCommandValidator()
    {
    }
}

public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="UpdateMemberCommandHandler"/> with the given application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and persist member data.</param>
    public UpdateMemberCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Processes an UpdateMemberCommand to update a member's information in the application data store.
    /// </summary>
    /// <param name="request">The command containing the update request for a member.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>`true` if the member was updated, `false` otherwise.</returns>
    /// <exception cref="System.NotImplementedException">Thrown until the handler implementation is provided.</exception>
    public async Task<bool> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
