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
    public GetMemberLoansQueryValidator()
    {
    }
}

public class GetMemberLoansQueryHandler : IRequestHandler<GetMemberLoansQuery, MemberLoansVm>
{
    private readonly IApplicationDbContext _context;

    public GetMemberLoansQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<MemberLoansVm> Handle(GetMemberLoansQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
