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
    /// <summary>
    /// Initializes a new instance of the <see cref="CheckLoanEligibilityQueryValidator"/> class.
    /// </summary>
    /// <remarks>
    /// This validator currently does not register any validation rules.
    /// </remarks>
    public CheckLoanEligibilityQueryValidator()
    {
    }
}

public class CheckLoanEligibilityQueryHandler : IRequestHandler<CheckLoanEligibilityQuery, LoanEligibilityVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="CheckLoanEligibilityQueryHandler"/> with the application database context.
    /// </summary>
    /// <param name="context">The application database context used to access persistent application data.</param>
    public CheckLoanEligibilityQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a CheckLoanEligibilityQuery and returns a LoanEligibilityVm representing the calculated loan eligibility.
    /// </summary>
    /// <param name="request">The eligibility check request.</param>
    /// <param name="cancellationToken">Cancellation token to observe while processing the request.</param>
    /// <returns>A <see cref="LoanEligibilityVm"/> containing the loan eligibility results.</returns>
    public async Task<LoanEligibilityVm> Handle(CheckLoanEligibilityQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
