using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Investments.Commands.CreateInvestment;

public record CreateInvestmentCommand : IRequest<int>
{
}

public class CreateInvestmentCommandValidator : AbstractValidator<CreateInvestmentCommand>
{
    public CreateInvestmentCommandValidator()
    {
    }
}

public class CreateInvestmentCommandHandler : IRequestHandler<CreateInvestmentCommand, int>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="CreateInvestmentCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and persist investment entities.</param>
    public CreateInvestmentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Creates a new investment based on the provided command and returns its identifier.
    /// </summary>
    /// <param name="request">Command containing the data required to create the investment.</param>
    /// <returns>The newly created investment's integer identifier.</returns>
    public async Task<int> Handle(CreateInvestmentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
