using Zeira.Application.Common.Interfaces;

namespace Zeira.Application.Settings.Queries.GetChamaSettings;

public record GetChamaSettingsQuery : IRequest<ChamaSettingsVm>
{
}

public class ChamaSettingsVm
{
}

public class GetChamaSettingsQueryValidator : AbstractValidator<GetChamaSettingsQuery>
{
    public GetChamaSettingsQueryValidator()
    {
    }
}

public class GetChamaSettingsQueryHandler : IRequestHandler<GetChamaSettingsQuery, ChamaSettingsVm>
{
    private readonly IApplicationDbContext _context;

    public GetChamaSettingsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ChamaSettingsVm> Handle(GetChamaSettingsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
