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
    /// <summary>
    /// Initializes a new instance of the <see cref="GetContributionsQueryValidator"/> class.
    /// </summary>
    /// <remarks>
    /// Register validation rules for <see cref="GetContributionsQuery"/> in this constructor.
    /// </remarks>
    public GetContributionsQueryValidator()
    {
    }
}

public class GetContributionsQueryHandler : IRequestHandler<GetContributionsQuery, ContributionsVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="GetContributionsQueryHandler"/>.
    /// </summary>
    /// <param name="context">The application database context used to access persistence for handling the query.</param>
    public GetContributionsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetContributionsQuery and produces the contributions response.
    /// </summary>
    /// <param name="request">The query requesting contributions.</param>
    /// <returns>A ContributionsVm containing the requested contributions.</returns>
    /// <exception cref="NotImplementedException">Thrown until the handler is implemented.</exception>
    public async Task<ContributionsVm> Handle(GetContributionsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
