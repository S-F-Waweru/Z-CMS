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
    /// <summary>
    /// Initializes a new instance of <see cref="GetChamaSettingsQueryValidator"/> and configures validation rules for <see cref="GetChamaSettingsQuery"/>.
    /// </summary>
    public GetChamaSettingsQueryValidator()
    {
    }
}

public class GetChamaSettingsQueryHandler : IRequestHandler<GetChamaSettingsQuery, ChamaSettingsVm>
{
    private readonly IApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of <see cref="GetChamaSettingsQueryHandler"/> with the specified application database context.
    /// </summary>
    /// <param name="context">The application database context used to access persistence for retrieving Chama settings.</param>
    public GetChamaSettingsQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Handles a GetChamaSettingsQuery to retrieve Chama configuration settings.
    /// </summary>
    /// <param name="request">The query requesting Chama settings.</param>
    /// <param name="cancellationToken">Token to observe while awaiting the operation.</param>
    /// <returns>A <see cref="ChamaSettingsVm"/> containing the Chama settings.</returns>
    public async Task<ChamaSettingsVm> Handle(GetChamaSettingsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
