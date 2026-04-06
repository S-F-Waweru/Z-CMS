using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Commands.UpdateContribution;

public record UpdateContributionCommand : IRequest<bool>
{
}

public class UpdateContributionCommandValidator : AbstractValidator<UpdateContributionCommand>
{
    public UpdateContributionCommandValidator()
    {
    }
}

public class UpdateContributionCommandHandler : IRequestHandler<UpdateContributionCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public UpdateContributionCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(UpdateContributionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
