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
    public GetChamaLoansQueryValidator()
    {
    }
}

public class GetChamaLoansQueryHandler : IRequestHandler<GetChamaLoansQuery, ChamaLoansVm>
{
    private readonly IApplicationDbContext _context;

    public GetChamaLoansQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ChamaLoansVm> Handle(GetChamaLoansQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
