using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Contributions.Commands.DeleteContribution;

public record DeleteContributionCommand : IRequest<bool>
{
}

public class DeleteContributionCommandValidator : AbstractValidator<DeleteContributionCommand>
{
    /// <summary>
    /// Initializes a new instance of <see cref="DeleteContributionCommandValidator"/>.
    /// </summary>
    /// <remarks>
    /// No validation rules are defined for <see cref="DeleteContributionCommand"/>; add rules to enforce command constraints.
    /// </remarks>
    public DeleteContributionCommandValidator()
    {
    }
}

public class DeleteContributionCommandHandler : IRequestHandler<DeleteContributionCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="DeleteContributionCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and persist contribution data.</param>
    public DeleteContributionCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Deletes the contribution specified by the command and indicates whether the deletion succeeded.
    /// </summary>
    /// <param name="request">The command representing the contribution to delete.</param>
    /// <returns>`true` if the contribution was deleted, `false` otherwise.</returns>
    public async Task<bool> Handle(DeleteContributionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
