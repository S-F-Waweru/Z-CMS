using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.ChamaLoans.Commands.CreateChamaLoan;

public record CreateChamaLoanCommand : IRequest<int>
{
}

public class CreateChamaLoanCommandValidator : AbstractValidator<CreateChamaLoanCommand>
{
    public CreateChamaLoanCommandValidator()
    {
    }
}

public class CreateChamaLoanCommandHandler : IRequestHandler<CreateChamaLoanCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateChamaLoanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateChamaLoanCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
