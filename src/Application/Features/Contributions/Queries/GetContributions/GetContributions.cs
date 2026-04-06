using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Queries.GetContributions;

public record GetContributionsQuery : IRequest<ContributionsVm>
{
}

public class ContributionsVm
{
}

public class GetContributionsQueryValidator : AbstractValidator<GetContributionsQuery>
{
    public GetContributionsQueryValidator()
    {
    }
}

public class GetContributionsQueryHandler : IRequestHandler<GetContributionsQuery, ContributionsVm>
{
    private readonly IApplicationDbContext _context;

    public GetContributionsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ContributionsVm> Handle(GetContributionsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
