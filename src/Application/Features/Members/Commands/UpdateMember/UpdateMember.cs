using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Commands.UpdateMember;

public record UpdateMemberCommand : IRequest<bool>
{
}

public class UpdateMemberCommandValidator : AbstractValidator<UpdateMemberCommand>
{
    public UpdateMemberCommandValidator()
    {
    }
}

public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public UpdateMemberCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
