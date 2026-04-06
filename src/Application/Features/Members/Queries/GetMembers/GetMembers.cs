using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Queries.GetMembers;

public record GetMembersQuery : IRequest<MembersVm>
{
}

public class GetMembersQueryValidator : AbstractValidator<GetMembersQuery>
{
    /// <summary>
    /// Initializes a new instance of <see cref="GetMembersQueryValidator"/>.
    /// </summary>
    /// <remarks>
    /// No validation rules are configured in this validator.
    /// </remarks>
    public GetMembersQueryValidator()
    {
    }
}

public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, MembersVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Creates a new <see cref="GetMembersQueryHandler"/> using the provided application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and query member data.</param>
    public GetMembersQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetMembersQuery and returns a view model containing the requested members.
    /// </summary>
    /// <returns>A <see cref="MembersVm"/> populated with the members retrieved by the query.</returns>
    public async Task<MembersVm> Handle(GetMembersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

public class MembersVm
{
}
