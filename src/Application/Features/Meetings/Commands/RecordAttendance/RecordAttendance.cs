using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Meetings.Commands.RecordAttendance;

public record RecordAttendanceCommand : IRequest<bool>
{
}

public class RecordAttendanceCommandValidator : AbstractValidator<RecordAttendanceCommand>
{
    public RecordAttendanceCommandValidator()
    {
    }
}

public class RecordAttendanceCommandHandler : IRequestHandler<RecordAttendanceCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public RecordAttendanceCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(RecordAttendanceCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
