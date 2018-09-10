using Abp.Authorization;
using ABP_CORE_MPA.Authorization.Roles;
using ABP_CORE_MPA.Authorization.Users;

namespace ABP_CORE_MPA.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
