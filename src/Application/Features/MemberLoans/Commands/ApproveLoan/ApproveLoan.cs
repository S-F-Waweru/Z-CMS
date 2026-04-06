using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Commands.ApproveLoan;

public record ApproveLoanCommand : IRequest<bool>
{
}

public class ApproveLoanCommandValidator : AbstractValidator<ApproveLoanCommand>
{
    /// <summary>
    /// Creates a new ApproveLoanCommandValidator.
    /// </summary>
    /// <remarks>
    /// Validator for <see cref="ApproveLoanCommand"/>; currently does not define any validation rules.
    /// </remarks>
    public ApproveLoanCommandValidator()
    {
    }
}

public class ApproveLoanCommandHandler : IRequestHandler<ApproveLoanCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="ApproveLoanCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to access persistence.</param>
    public ApproveLoanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Processes an ApproveLoanCommand to approve a member loan and persist the change to the application database.
    /// </summary>
    /// <param name="request">The approval command representing the loan approval operation.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>`true` if the loan was approved and database changes were saved; `false` otherwise.</returns>
    public async Task<bool> Handle(ApproveLoanCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
