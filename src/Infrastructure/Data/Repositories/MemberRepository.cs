using Microsoft.EntityFrameworkCore;
using Zeira.Domain.Entities;
using Zeira.Domain.Interfaces;

namespace Zeira.Infrastructure.Data.Repositories;

public class MemberRepository : IMemberRepository
{
    private readonly ApplicationDbContext _context;

    public MemberRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Member?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        => await _context.Members.FindAsync(new object[] { id }, cancellationToken);

    public async Task<(List<Member> Members, int TotalCount)> GetAllAsync(int page, int pageSize, CancellationToken cancellationToken = default)
    {
        var query = _context.Members.AsQueryable();
        var totalCount = await query.CountAsync(cancellationToken);
        var members = await query
            .OrderBy(m => m.FullName)
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync(cancellationToken);

        return (members, totalCount);
    }

    public async Task CreateAsync(Member member, CancellationToken cancellationToken = default)
    {
        await _context.Members.AddAsync(member, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(Member member, CancellationToken cancellationToken = default)
    {
        _context.Members.Update(member);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(Member member, CancellationToken cancellationToken = default)
    {
        _context.Members.Remove(member);
        await _context.SaveChangesAsync(cancellationToken);
    }
}
