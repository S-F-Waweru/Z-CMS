using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Queries.GetMembers;

public record GetMembersQuery : IRequest<MembersVm>
{
}

public class GetMembersQueryValidator : AbstractValidator<GetMembersQuery>
{
    public GetMembersQueryValidator()
    {
    }
}

public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, MembersVm>
{
    private readonly IApplicationDbContext _context;

    public GetMembersQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<MembersVm> Handle(GetMembersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public class MembersVm
{
}
