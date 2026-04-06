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

    /// <summary>
    /// Initializes a new instance of <see cref="CreateMeetingCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used for data access.</param>
    public CreateMeetingCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a meeting from the provided command and returns the new meeting's identifier.
    /// </summary>
    /// <param name="request">Command containing the data required to create the meeting.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>The identifier of the created meeting.</returns>
    /// <exception cref="NotImplementedException">Thrown because the handler is not yet implemented.</exception>
    public async Task<int> Handle(CreateMeetingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
