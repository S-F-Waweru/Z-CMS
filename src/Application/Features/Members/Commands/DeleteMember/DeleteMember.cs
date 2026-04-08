using Zeira.Application.Common.Interfaces;
using Zeira.Domain.Interfaces;

namespace Zeira.Application.Members.Commands.DeleteMember;

public record DeleteMemberCommand(int MemberId) : IRequest<bool>;

public class DeleteMemberCommandValidator : AbstractValidator<DeleteMemberCommand>
{
    public DeleteMemberCommandValidator()
    {
        RuleFor(m => m.MemberId).GreaterThan(0);
    }
}

public class DeleteMemberCommandHandler : IRequestHandler<DeleteMemberCommand, bool>
{
    private readonly IMemberRepository _repository;

    public DeleteMemberCommandHandler(IMemberRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteMemberCommand request, CancellationToken cancellationToken)
    {
        var member = await _repository.GetByIdAsync(request.MemberId, cancellationToken);
        if (member is null) return false;

        await _repository.DeleteAsync(member, cancellationToken);
        return true;
    }
}
