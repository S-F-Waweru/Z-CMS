using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.ChamaLoans.Commands.RecordChamaRepayment;

public record RecordChamaRepaymentCommand : IRequest<bool>
{
}

public class RecordChamaRepaymentCommandValidator : AbstractValidator<RecordChamaRepaymentCommand>
{
    public RecordChamaRepaymentCommandValidator()
    {
    }
}

public class RecordChamaRepaymentCommandHandler : IRequestHandler<RecordChamaRepaymentCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public RecordChamaRepaymentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(RecordChamaRepaymentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
