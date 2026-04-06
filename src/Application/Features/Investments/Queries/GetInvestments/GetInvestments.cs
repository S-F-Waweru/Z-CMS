using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Investments.Queries.GetInvestments;

public record GetInvestmentsQuery : IRequest<InvestmentsVm>
{
}

public class InvestmentsVm
{
}

public class GetInvestmentsQueryValidator : AbstractValidator<GetInvestmentsQuery>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetInvestmentsQueryValidator"/> class.
    /// </summary>
    public GetInvestmentsQueryValidator()
    {
    }
}

public class GetInvestmentsQueryHandler : IRequestHandler<GetInvestmentsQuery, InvestmentsVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="GetInvestmentsQueryHandler"/> with the application database context.
    /// </summary>
    public GetInvestmentsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetInvestmentsQuery and produces an InvestmentsVm representing the requested investments.
    /// </summary>
    /// <returns>An InvestmentsVm containing the requested investments.</returns>
    /// <exception cref="NotImplementedException">Thrown until the query handler is implemented.</exception>
    public async Task<InvestmentsVm> Handle(GetInvestmentsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
