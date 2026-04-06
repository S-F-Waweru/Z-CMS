using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Commands.ApplyForLoan;

public record ApplyForLoanCommand : IRequest<int>
{
}

public class ApplyForLoanCommandValidator : AbstractValidator<ApplyForLoanCommand>
{
    public ApplyForLoanCommandValidator()
    {
    }
}

public class ApplyForLoanCommandHandler : IRequestHandler<ApplyForLoanCommand, int>
{
    private readonly IApplicationDbContext _context;

    public ApplyForLoanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(ApplyForLoanCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
