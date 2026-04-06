using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Members.Commands.CreateMember;

public record CreateMemberCommand : IRequest<int>
{
}

public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    /// <summary>
    /// Initializes a new instance of <see cref="CreateMemberCommandValidator"/>.
    /// </summary>
    /// <remarks>
    /// No validation rules are configured for the command yet.
    /// </remarks>
    public CreateMemberCommandValidator()
    {
    }
}

public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand, int>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="CreateMemberCommandHandler"/> with the application's database context.
    /// </summary>
    /// <param name="context">The application database context used to access and modify member data.</param>
    public CreateMemberCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a CreateMemberCommand and returns the identifier of the created member.
    /// </summary>
    /// <param name="request">The command containing data required to create a member.</param>
    /// <param name="cancellationToken">Token to observe for cancellation.</param>
    /// <returns>The identifier of the created member.</returns>
    /// <exception cref="NotImplementedException">Thrown until the handler implementation is complete.</exception>
    public async Task<int> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
