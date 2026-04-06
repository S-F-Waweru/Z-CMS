using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Commands.ApproveLoanAtMeeting;

public record ApproveLoanAtMeetingCommand : IRequest<bool>
{
}

public class ApproveLoanAtMeetingCommandValidator : AbstractValidator<ApproveLoanAtMeetingCommand>
{
    /// <summary>
    /// Initializes a new instance of <see cref="ApproveLoanAtMeetingCommandValidator"/>.
    /// </summary>
    /// <remarks>
    /// No validation rules are configured for this validator.
    /// </remarks>
    public ApproveLoanAtMeetingCommandValidator()
    {
    }
}

public class ApproveLoanAtMeetingCommandHandler : IRequestHandler<ApproveLoanAtMeetingCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="ApproveLoanAtMeetingCommandHandler"/> using the specified application database context.
    /// </summary>
    public ApproveLoanAtMeetingCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles the command to approve a loan during a meeting.
    /// </summary>
    /// <param name="request">The command containing data required to approve the loan at a meeting.</param>
    /// <returns>`true` if the loan was approved, `false` otherwise.</returns>
    /// <exception cref="System.NotImplementedException">Thrown because the handler is not yet implemented.</exception>
    public async Task<bool> Handle(ApproveLoanAtMeetingCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
