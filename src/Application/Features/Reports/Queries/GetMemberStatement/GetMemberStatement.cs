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
    /// <summary>
    /// Initializes a new instance of <see cref="GetMemberStatementQueryValidator"/>.
    /// </summary>
    public GetMemberStatementQueryValidator()
    {
    }
}

public class GetMemberStatementQueryHandler : IRequestHandler<GetMemberStatementQuery, MemberStatementVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new <see cref="GetMemberStatementQueryHandler"/> with the provided application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and query persisted application data.</param>
    public GetMemberStatementQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetMemberStatementQuery and produces a MemberStatementVm containing the requested member statement.
    /// </summary>
    /// <param name="request">The query request identifying which member statement to generate.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the task to complete.</param>
    /// <returns>A <see cref="MemberStatementVm"/> representing the requested member statement.</returns>
    /// <exception cref="NotImplementedException">Thrown until the handler implementation is completed.</exception>
    public async Task<MemberStatementVm> Handle(GetMemberStatementQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
