using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Settings.Commands.UpdateChamaSettings;

public record UpdateChamaSettingsCommand : IRequest<bool>
{
}

public class UpdateChamaSettingsCommandValidator : AbstractValidator<UpdateChamaSettingsCommand>
{
    public UpdateChamaSettingsCommandValidator()
    {
    }
}

public class UpdateChamaSettingsCommandHandler : IRequestHandler<UpdateChamaSettingsCommand, bool>
{
    private readonly IApplicationDbContext _context;

    public UpdateChamaSettingsCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(UpdateChamaSettingsCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
