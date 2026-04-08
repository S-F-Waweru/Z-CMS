using Zeira.Application.Common.Interfaces;
using Zeira.Domain.Entities;
using Zeira.Domain.Enums;
using Zeira.Domain.Interfaces;

namespace Zeira.Application.Members.Commands.CreateMember;

public record CreateMemberCommand(
    string FullName,
    string Email,
    string PhoneNumber,
    MemberRole Role,
    MemberStatus Status,
    DateOnly JoinDate
) : IRequest<int>;


public class CreateMemberCommandValidator : AbstractValidator<CreateMemberCommand>
{
    public CreateMemberCommandValidator()
    {
        RuleFor(x => x.FullName)
            .NotEmpty()
            .MaximumLength(150);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress()
            .MaximumLength(150);

        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(x => x.Role)
            .IsInEnum();

        RuleFor(x => x.Status)
            .IsInEnum();

        RuleFor(x => x.JoinDate)
            .NotEmpty()
            .LessThanOrEqualTo(DateOnly.FromDateTime(DateTime.Today));
    }
}

public class CreateMemberCommandHandler : IRequestHandler<CreateMemberCommand, int>
{
    private readonly IMemberRepository _repository;

    public CreateMemberCommandHandler(IMemberRepository repository)
    {
        _repository = repository;
    }

    public async Task<int> Handle(CreateMemberCommand request, CancellationToken cancellationToken)
    {
        var member = new Member
        {
            FullName = request.FullName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            Role = request.Role,
            Status = request.Status,
            JoinDate = request.JoinDate
        };

        await _repository.CreateAsync(member, cancellationToken);
        return member.Id;
    }
}
