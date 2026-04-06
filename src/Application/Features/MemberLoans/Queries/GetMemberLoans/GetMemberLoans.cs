using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Queries.GetMemberLoans;

public record GetMemberLoansQuery : IRequest<MemberLoansVm>
{
}

public class MemberLoansVm
{
}

public class GetMemberLoansQueryValidator : AbstractValidator<GetMemberLoansQuery>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetMemberLoansQueryValidator"/> class.
    /// </summary>
    /// <remarks>
    /// No validation rules are currently configured.
    /// </remarks>
    public GetMemberLoansQueryValidator()
    {
    }
}

public class GetMemberLoansQueryHandler : IRequestHandler<GetMemberLoansQuery, MemberLoansVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of GetMemberLoansQueryHandler with the provided application database context.
    /// </summary>
    /// <param name="context">The application database context used to access persistent data.</param>
    public GetMemberLoansQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetMemberLoansQuery and produces a MemberLoansVm containing the member's loans.
    /// </summary>
    /// <param name="request">The query request to retrieve member loans.</param>
    /// <param name="cancellationToken">Token to observe for cancellation.</param>
    /// <returns>A <see cref="MemberLoansVm"/> containing the retrieved loans.</returns>
    /// <exception cref="System.NotImplementedException">Thrown until the query handling is implemented.</exception>
    public async Task<MemberLoansVm> Handle(GetMemberLoansQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
