using Zeira.Domain.Entities;

namespace Zeira.Domain.Interfaces;
public interface IMemberRepository
    {
        Task<Member?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<(List<Member> Members, int TotalCount)> GetAllAsync(int page, int pageSize, CancellationToken cancellationToken = default);
        Task CreateAsync(Member member, CancellationToken cancellationToken = default);
        Task UpdateAsync(Member member, CancellationToken cancellationToken = default);
        Task DeleteAsync(Member member, CancellationToken cancellationToken = default);
    }

