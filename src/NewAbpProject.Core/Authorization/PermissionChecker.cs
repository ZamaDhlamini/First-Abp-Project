using Abp.Authorization;
using NewAbpProject.Authorization.Roles;
using NewAbpProject.Authorization.Users;

namespace NewAbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
