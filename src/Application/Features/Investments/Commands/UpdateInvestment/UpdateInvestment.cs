using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Investments.Commands.UpdateInvestment;

public record UpdateInvestmentCommand : IRequest<bool>
{
}

public class UpdateInvestmentCommandValidator : AbstractValidator<UpdateInvestmentCommand>
{
    public UpdateInvestmentCommandValidator()
    {
    }
}

public class UpdateInvestmentCommandHandler : IRequestHandler<UpdateInvestmentCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public UpdateInvestmentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(UpdateInvestmentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
