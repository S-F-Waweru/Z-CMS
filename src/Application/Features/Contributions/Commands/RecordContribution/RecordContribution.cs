using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Commands.RecordContribution;

public record RecordContributionCommand : IRequest<int>
{
}

public class RecordContributionCommandValidator : AbstractValidator<RecordContributionCommand>
{
    public RecordContributionCommandValidator()
    {
    }
}

public class RecordContributionCommandHandler : IRequestHandler<RecordContributionCommand, int>
{
    private readonly IApplicationDbContext _context;

    public RecordContributionCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(RecordContributionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
