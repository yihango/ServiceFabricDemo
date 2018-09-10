using System.Collections.Generic;
using System.Linq;
using ABP_CORE_MPA.Roles.Dto;
using ABP_CORE_MPA.Users.Dto;

namespace ABP_CORE_MPA.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.RoleNames != null && User.RoleNames.Any(r => r == role.NormalizedName);
        }
    }
}
