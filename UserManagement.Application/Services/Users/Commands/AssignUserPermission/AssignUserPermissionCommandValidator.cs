using FluentValidation;

namespace UserManagement.Application.Services.Users.Commands.AssignUserPermission
{
    public class AssignUserPermissionCommandValidator : AbstractValidator<AssignUserPermissionCommand>
    {
        public AssignUserPermissionCommandValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().GreaterThan(0);
            RuleFor(x => x.PermissionIds).NotNull();
        }
    }
}