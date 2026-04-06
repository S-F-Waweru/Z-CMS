using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Investments.Commands.UpdateInvestment;

public record UpdateInvestmentCommand : IRequest<bool>
{
}

public class UpdateInvestmentCommandValidator : AbstractValidator<UpdateInvestmentCommand>
{
    /// <summary>
    /// Defines validation rules for <see cref="UpdateInvestmentCommand"/>.
    /// </summary>
    public UpdateInvestmentCommandValidator()
    {
    }
}

public class UpdateInvestmentCommandHandler : IRequestHandler<UpdateInvestmentCommand, bool>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="UpdateInvestmentCommandHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to query and persist investment entities.</param>
    public UpdateInvestmentCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles an UpdateInvestmentCommand to update an investment and indicates whether the update succeeded.
    /// </summary>
    /// <param name="request">The command containing the update details for the investment.</param>
    /// <returns>true if the investment was updated successfully, false otherwise.</returns>
    public async Task<bool> Handle(UpdateInvestmentCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
