using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Commands.UpdateContribution;

public record UpdateContributionCommand : IRequest<bool>
{
}

public class UpdateContributionCommandValidator : AbstractValidator<UpdateContributionCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateContributionCommandValidator"/> class.
    /// </summary>
    public UpdateContributionCommandValidator()
    {
    }
}

public class UpdateContributionCommandHandler : IRequestHandler<UpdateContributionCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="UpdateContributionCommandHandler"/> with the provided application database context.
    /// </summary>
    /// <param name="context">The application database context used to access persistence operations.</param>
    public UpdateContributionCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Processes an UpdateContributionCommand by applying the requested changes to the contribution aggregate.
    /// </summary>
    /// <param name="request">The command containing the contribution identifier and updated data.</param>
    /// <param name="cancellationToken">Token to observe while awaiting the operation.</param>
    /// <returns>`true` if the contribution was successfully updated, `false` otherwise.</returns>
    public async Task<bool> Handle(UpdateContributionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
