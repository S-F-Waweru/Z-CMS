using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Commands.ApplyForLoan;

public record ApplyForLoanCommand : IRequest<int>
{
}

public class ApplyForLoanCommandValidator : AbstractValidator<ApplyForLoanCommand>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ApplyForLoanCommandValidator"/> class.
    /// </summary>
    public ApplyForLoanCommandValidator()
    {
    }
}

public class ApplyForLoanCommandHandler : IRequestHandler<ApplyForLoanCommand, int>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="ApplyForLoanCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and persist data for handling the command.</param>
    public ApplyForLoanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles an ApplyForLoanCommand by creating a new member loan and returning its identifier.
    /// </summary>
    /// <param name="request">The command containing the loan application details.</param>
    /// <returns>The identifier of the created loan.</returns>
    /// <exception cref="System.NotImplementedException">Thrown when the handler has not been implemented.</exception>
    public async Task<int> Handle(ApplyForLoanCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
