using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Commands.RecordLoanRepayment;

public record RecordLoanRepaymentCommand : IRequest<bool>
{
}

public class RecordLoanRepaymentCommandValidator : AbstractValidator<RecordLoanRepaymentCommand>
{
    public RecordLoanRepaymentCommandValidator()
    {
    }
}

public class RecordLoanRepaymentCommandHandler : IRequestHandler<RecordLoanRepaymentCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public RecordLoanRepaymentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(RecordLoanRepaymentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
