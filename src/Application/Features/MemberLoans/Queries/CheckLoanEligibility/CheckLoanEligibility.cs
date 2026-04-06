using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Queries.CheckLoanEligibility;

public record CheckLoanEligibilityQuery : IRequest<LoanEligibilityVm>
{
}

public class LoanEligibilityVm
{
}

public class CheckLoanEligibilityQueryValidator : AbstractValidator<CheckLoanEligibilityQuery>
{
    public CheckLoanEligibilityQueryValidator()
    {
    }
}

public class CheckLoanEligibilityQueryHandler : IRequestHandler<CheckLoanEligibilityQuery, LoanEligibilityVm>
{
    private readonly IApplicationDbContext _context;

    public CheckLoanEligibilityQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<LoanEligibilityVm> Handle(CheckLoanEligibilityQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
