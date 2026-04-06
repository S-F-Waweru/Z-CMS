using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Commands.RecordMeetingMinutes;

public record RecordMeetingMinutesCommand : IRequest<bool>
{
}

public class RecordMeetingMinutesCommandValidator : AbstractValidator<RecordMeetingMinutesCommand>
{
    public RecordMeetingMinutesCommandValidator()
    {
    }
}

public class RecordMeetingMinutesCommandHandler : IRequestHandler<RecordMeetingMinutesCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public RecordMeetingMinutesCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(RecordMeetingMinutesCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
