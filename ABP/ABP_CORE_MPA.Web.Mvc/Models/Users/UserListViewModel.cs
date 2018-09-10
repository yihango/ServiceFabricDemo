using System.Collections.Generic;
using ABP_CORE_MPA.Roles.Dto;
using ABP_CORE_MPA.Users.Dto;

namespace ABP_CORE_MPA.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
