namespace Zeira.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    /// <summary>
/// Persists all tracked changes to the underlying data store.
/// </summary>
/// <param name="cancellationToken">Cancellation token to observe while performing the save operation.</param>
/// <returns>The number of state entries written to the underlying data store.</returns>
Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
