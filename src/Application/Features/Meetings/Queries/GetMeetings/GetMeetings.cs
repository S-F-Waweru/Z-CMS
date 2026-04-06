using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Queries.GetMeetings;

public record GetMeetingsQuery : IRequest<MeetingsVm>
{
}

public class MeetingsVm
{
}

public class GetMeetingsQueryValidator : AbstractValidator<GetMeetingsQuery>
{
    public GetMeetingsQueryValidator()
    {
    }
}

public class GetMeetingsQueryHandler : IRequestHandler<GetMeetingsQuery, MeetingsVm>
{
    private readonly IApplicationDbContext _context;

    public GetMeetingsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<MeetingsVm> Handle(GetMeetingsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
