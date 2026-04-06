using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Reports.Queries.GetMemberStatement;

public record GetMemberStatementQuery : IRequest<MemberStatementVm>
{
}

public class MemberStatementVm
{
}

public class GetMemberStatementQueryValidator : AbstractValidator<GetMemberStatementQuery>
{
    public GetMemberStatementQueryValidator()
    {
    }
}

public class GetMemberStatementQueryHandler : IRequestHandler<GetMemberStatementQuery, MemberStatementVm>
{
    private readonly IApplicationDbContext _context;

    public GetMemberStatementQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<MemberStatementVm> Handle(GetMemberStatementQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
