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
    public GetInvestmentsQueryValidator()
    {
    }
}

public class GetInvestmentsQueryHandler : IRequestHandler<GetInvestmentsQuery, InvestmentsVm>
{
    private readonly IApplicationDbContext _context;

    public GetInvestmentsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<InvestmentsVm> Handle(GetInvestmentsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
