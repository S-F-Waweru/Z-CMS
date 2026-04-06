using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Reports.Queries.GetGroupSummary;

public record GetGroupSummaryQuery : IRequest<GroupSummaryVm>
{
}

public class GroupSummaryVm
{
}

public class GetGroupSummaryQueryValidator : AbstractValidator<GetGroupSummaryQuery>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GetGroupSummaryQueryValidator"/> class.
    /// </summary>
    public GetGroupSummaryQueryValidator()
    {
    }
}

public class GetGroupSummaryQueryHandler : IRequestHandler<GetGroupSummaryQuery, GroupSummaryVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new <see cref="GetGroupSummaryQueryHandler"/> with the application database context.
    /// </summary>
    public GetGroupSummaryQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetGroupSummaryQuery and produces a GroupSummaryVm containing summary information for a group.
    /// </summary>
    /// <param name="request">The query request to retrieve the group summary.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>A <see cref="GroupSummaryVm"/> containing the group's summary data.</returns>
    public async Task<GroupSummaryVm> Handle(GetGroupSummaryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
