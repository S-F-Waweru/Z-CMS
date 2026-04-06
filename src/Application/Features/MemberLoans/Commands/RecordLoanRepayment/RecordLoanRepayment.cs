using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.MemberLoans.Commands.RecordLoanRepayment;

public record RecordLoanRepaymentCommand : IRequest<bool>
{
}

public class RecordLoanRepaymentCommandValidator : AbstractValidator<RecordLoanRepaymentCommand>
{
    /// <summary>
    /// Validates <see cref="RecordLoanRepaymentCommand"/> instances.
    /// </summary>
    public RecordLoanRepaymentCommandValidator()
    {
    }
}

public class RecordLoanRepaymentCommandHandler : IRequestHandler<RecordLoanRepaymentCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="RecordLoanRepaymentCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to access and persist loan repayment data.</param>
    public RecordLoanRepaymentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Records a loan repayment and indicates whether the operation succeeded.
    /// </summary>
    /// <param name="request">The command describing the loan repayment to record.</param>
    /// <param name="cancellationToken">Token to observe while waiting for the operation to complete.</param>
    /// <returns>`true` if the repayment was recorded successfully, `false` otherwise.</returns>
    /// <exception cref="NotImplementedException">Thrown until the handler implementation is provided.</exception>
    public async Task<bool> Handle(RecordLoanRepaymentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
