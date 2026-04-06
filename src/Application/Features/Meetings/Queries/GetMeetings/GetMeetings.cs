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
    /// <summary>
    /// Initializes a new instance of <see cref="GetMeetingsQueryValidator"/> and configures validation rules for <see cref="GetMeetingsQuery"/>.
    /// </summary>
    public GetMeetingsQueryValidator()
    {
    }
}

public class GetMeetingsQueryHandler : IRequestHandler<GetMeetingsQuery, MeetingsVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="GetMeetingsQueryHandler"/> with the application database context.
    /// </summary>
    public GetMeetingsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetMeetingsQuery and produces the corresponding MeetingsVm response.
    /// </summary>
    /// <param name="request">The query requesting meeting data.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>The <see cref="MeetingsVm"/> containing the retrieved meetings.</returns>
    /// <exception cref="NotImplementedException">Thrown until the handler implementation is completed.</exception>
    public async Task<MeetingsVm> Handle(GetMeetingsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
