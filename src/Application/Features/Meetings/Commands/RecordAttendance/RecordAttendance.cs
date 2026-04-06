using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Commands.RecordAttendance;

public record RecordAttendanceCommand : IRequest<bool>
{
}

public class RecordAttendanceCommandValidator : AbstractValidator<RecordAttendanceCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordAttendanceCommandValidator"/> class.
    /// </summary>
    /// <remarks>
    /// No validation rules are configured.
    /// </remarks>
    public RecordAttendanceCommandValidator()
    {
    }
}

public class RecordAttendanceCommandHandler : IRequestHandler<RecordAttendanceCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="RecordAttendanceCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used for data access.</param>
    public RecordAttendanceCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a <see cref="RecordAttendanceCommand"/> by recording attendance for the targeted meeting.
    /// </summary>
    /// <param name="request">The command that initiates recording attendance.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>`true` if attendance was recorded successfully, `false` otherwise.</returns>
    public async Task<bool> Handle(RecordAttendanceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
