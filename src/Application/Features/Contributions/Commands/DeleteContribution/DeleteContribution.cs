using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Commands.DeleteContribution;

public record DeleteContributionCommand : IRequest<bool>
{
}

public class DeleteContributionCommandValidator : AbstractValidator<DeleteContributionCommand>
{
    public DeleteContributionCommandValidator()
    {
    }
}

public class DeleteContributionCommandHandler : IRequestHandler<DeleteContributionCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public DeleteContributionCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteContributionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
