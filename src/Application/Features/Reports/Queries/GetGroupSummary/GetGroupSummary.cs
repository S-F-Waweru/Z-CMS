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
    public GetGroupSummaryQueryValidator()
    {
    }
}

public class GetGroupSummaryQueryHandler : IRequestHandler<GetGroupSummaryQuery, GroupSummaryVm>
{
    private readonly IApplicationDbContext _context;

    public GetGroupSummaryQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<GroupSummaryVm> Handle(GetGroupSummaryQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
