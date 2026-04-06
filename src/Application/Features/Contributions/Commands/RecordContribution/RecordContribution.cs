using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Commands.RecordContribution;

public record RecordContributionCommand : IRequest<int>
{
}

public class RecordContributionCommandValidator : AbstractValidator<RecordContributionCommand>
{
    /// <summary>
    /// Creates a new <see cref="RecordContributionCommandValidator"/>.
    /// </summary>
    /// <remarks>
    /// The validator is created with no validation rules defined.
    /// </remarks>
    public RecordContributionCommandValidator()
    {
    }
}

public class RecordContributionCommandHandler : IRequestHandler<RecordContributionCommand, int>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="RecordContributionCommandHandler"/> with the provided application database context.
    /// </summary>
    /// <param name="context">The application database context used for persistence operations within the handler.</param>
    public RecordContributionCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Processes a RecordContributionCommand to create a contribution and produce its identifier.
    /// </summary>
    /// <param name="request">The command containing data for the contribution to create.</param>
    /// <returns>The identifier of the created contribution.</returns>
    /// <exception cref="NotImplementedException">Thrown when the handler has not been implemented.</exception>
    public async Task<int> Handle(RecordContributionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
