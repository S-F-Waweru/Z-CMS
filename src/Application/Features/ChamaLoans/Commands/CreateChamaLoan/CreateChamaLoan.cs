using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.ChamaLoans.Commands.CreateChamaLoan;

public record CreateChamaLoanCommand : IRequest<int>
{
}

public class CreateChamaLoanCommandValidator : AbstractValidator<CreateChamaLoanCommand>
{
    /// <summary>
    /// Initializes a new instance of <see cref="CreateChamaLoanCommandValidator"/>.
    /// </summary>
    public CreateChamaLoanCommandValidator()
    {
    }
}

public class CreateChamaLoanCommandHandler : IRequestHandler<CreateChamaLoanCommand, int>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="CreateChamaLoanCommandHandler"/> with required dependencies.
    /// </summary>
    /// <param name="context">The application database context used to access and modify persistent data.</param>
    public CreateChamaLoanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Processes a CreateChamaLoanCommand and creates a new Chama loan record.
    /// </summary>
    /// <param name="request">The command containing data required to create the Chama loan.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the task to complete.</param>
    /// <returns>The identifier of the newly created Chama loan.</returns>
    public async Task<int> Handle(CreateChamaLoanCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
