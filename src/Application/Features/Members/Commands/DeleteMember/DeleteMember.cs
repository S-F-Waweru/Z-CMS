using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Commands.DeleteMember;

public record DeleteMemberCommand : IRequest<bool>
{
}

public class DeleteMemberCommandValidator : AbstractValidator<DeleteMemberCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteMemberCommandValidator"/> class.
    /// </summary>
    public DeleteMemberCommandValidator()
    {
    }
}

public class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="DeleteMemberCommandHandler"/> that uses the provided application database context.
    /// </summary>
    public DeleteMemberCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Deletes the member described by the command and indicates whether the deletion succeeded.
    /// </summary>
    /// <param name="request">The command containing the details required to delete the member.</param>
    /// <returns>`true` if the member was deleted; `false` otherwise.</returns>
    public async Task<bool> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
