using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Commands.CreateMember;

public record CreateMemberCommand : IRequest<int>
{
}

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    public CreateMemberCommandValidator()
    {
    }
}

public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateMemberCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
