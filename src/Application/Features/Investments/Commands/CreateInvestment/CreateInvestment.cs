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

    public CreateInvestmentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateInvestmentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
