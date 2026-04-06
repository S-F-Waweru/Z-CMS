using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.ChamaLoans.Queries.GetChamaLoans;

public record GetChamaLoansQuery : IRequest<ChamaLoansVm>
{
}

public class ChamaLoansVm
{
}

public class GetChamaLoansQueryValidator : AbstractValidator<GetChamaLoansQuery>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetChamaLoansQueryValidator"/> class.
    /// </summary>
    public GetChamaLoansQueryValidator()
    {
    }
}

public class GetChamaLoansQueryHandler : IRequestHandler<GetChamaLoansQuery, ChamaLoansVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="GetChamaLoansQueryHandler"/> with the application database context.
    /// </summary>
    public GetChamaLoansQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetChamaLoansQuery and returns a view model containing chama loan data.
    /// </summary>
    /// <param name="request">The query request.</param>
    /// <param name="cancellationToken">Token to observe for cancellation.</param>
    /// <returns>A ChamaLoansVm containing the requested chama loans.</returns>
    /// <exception cref="NotImplementedException">The handler is not yet implemented.</exception>
    public async Task<ChamaLoansVm> Handle(GetChamaLoansQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
