using Zeira.Application.Common.Interfaces;
using Zeira.Domain.Enums;
using Zeira.Domain.Interfaces;

public record UpdateMemberCommand(
    int Id,
    string FullName,
    string Email,
    string PhoneNumber,
    MemberRole Role,
    MemberStatus Status,
    DateOnly JoinDate
) : IRequest<bool>;

public class UpdateMemberCommandValidator : AbstractValidator<UpdateMemberCommand>
{
    public UpdateMemberCommandValidator()
    {
        
        RuleFor(x => x.Id).GreaterThan(0);

        RuleFor(x => x.FullName).NotEmpty().MaximumLength(150);
        RuleFor(x => x.Email).NotEmpty().EmailAddress().MaximumLength(150);
        RuleFor(x => x.PhoneNumber).NotEmpty().MaximumLength(20);
        RuleFor(x => x.Role).IsInEnum();
        RuleFor(x => x.Status).IsInEnum();
        RuleFor(x => x.JoinDate).NotEmpty().LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Today));
    }
}

public class UpdateMemberHandler : IRequestHandler<UpdateMemberCommand, bool>
{
    private readonly IMemberRepository _repository;

    public UpdateMemberHandler(IMemberRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
    {
        var member = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (member is null) return false;

        member.FullName = request.FullName;
        member.Email = request.Email;
        member.PhoneNumber = request.PhoneNumber;
        member.Role = request.Role;
        member.Status = request.Status;
        member.JoinDate = request.JoinDate;

        await _repository.UpdateAsync(member, cancellationToken);
        return true;
    }
}
