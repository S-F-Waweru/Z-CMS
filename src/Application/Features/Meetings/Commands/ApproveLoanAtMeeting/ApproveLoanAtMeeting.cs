using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Commands.ApproveLoanAtMeeting;

public record ApproveLoanAtMeetingCommand : IRequest<bool>
{
}

public class ApproveLoanAtMeetingCommandValidator : AbstractValidator<ApproveLoanAtMeetingCommand>
{
    public ApproveLoanAtMeetingCommandValidator()
    {
    }
}

public class ApproveLoanAtMeetingCommandHandler : IRequestHandler<ApproveLoanAtMeetingCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public ApproveLoanAtMeetingCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(ApproveLoanAtMeetingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
