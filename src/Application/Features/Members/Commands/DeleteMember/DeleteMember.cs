using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Commands.DeleteMember;

public record DeleteMemberCommand : IRequest<bool>
{
}

public class DeleteMemberCommandValidator : AbstractValidator<DeleteMemberCommand>
{
    public DeleteMemberCommandValidator()
    {
    }
}

public class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public DeleteMemberCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
