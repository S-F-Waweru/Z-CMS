using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Commands.ApproveLoan;

public record ApproveLoanCommand : IRequest<bool>
{
}

public class ApproveLoanCommandValidator : AbstractValidator<ApproveLoanCommand>
{
    public ApproveLoanCommandValidator()
    {
    }
}

public class ApproveLoanCommandHandler : IRequestHandler<ApproveLoanCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public ApproveLoanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(ApproveLoanCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
