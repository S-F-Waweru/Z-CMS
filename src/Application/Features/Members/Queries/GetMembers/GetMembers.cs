using Zeira.Application.Common.Interfaces;
using Zeira.Domain.Enums;
using Zeira.Domain.Interfaces;

namespace Zeira.Application.Features.Members.Queries.GetMembers;

public record GetMembersQuery(int Page = 1, int PageSize = 10) : IRequest<MembersVm>;


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
        RuleFor(x => x.Page).GreaterThan(0);
        RuleFor(x => x.PageSize).InclusiveBetween(1, 100);
    }
}

public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, MembersVm>
{
    private readonly IMemberRepository _repository;

    /// <summary>
    /// Creates a new <see cref="GetMembersQueryHandler"/> using the provided application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and query member data.</param>
    public GetMembersQueryHandler(IMemberRepository repository)
    {
        _repository = repository;
    }

    /// <summary>
    /// Handles a GetMembersQuery and returns a view model containing the requested members.
    /// </summary>
    /// <returns>A <see cref="MembersVm"/> populated with the members retrieved by the query.</returns>
    public async Task<MembersVm> Handle(GetMembersQuery request, CancellationToken cancellationToken)
    {
        var (members, totalCount) = await _repository.GetAllAsync(request.Page, request.Page, cancellationToken);

        return new MembersVm
        {
            Members = members.Select(m => new MemberDto
            {
                Id = m.Id,
                FullName = m.FullName,
                Email = m.Email,
                PhoneNumber = m.PhoneNumber,
                Role = m.Role,
                Status = m.Status,
                JoinDate = m.JoinDate
            }).ToList(),
            TotalCount = totalCount,
            Page = request.Page,
            PageSize = request.PageSize
        };
    }
}

public class MembersVm
{
    public List<MemberDto> Members { get; set; } = [];
    public int TotalCount { get; set; }
    public int Page { get; set; }
    public int PageSize { get; set; }
}

public class MemberDto
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public MemberRole Role { get; set; }
    public MemberStatus Status { get; set; }
    public DateOnly JoinDate { get; set; }
}
