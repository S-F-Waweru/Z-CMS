using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Commands.CreateMeeting;

public record CreateMeetingCommand : IRequest<int>
{
}

public class CreateMeetingCommandValidator : AbstractValidator<CreateMeetingCommand>
{
    public CreateMeetingCommandValidator()
    {
    }
}

public class CreateMeetingCommandHandler : IRequestHandler<CreateMeetingCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateMeetingCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
