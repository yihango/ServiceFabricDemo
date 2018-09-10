using System.Collections.Generic;
using ABP_CORE_MPA.Roles.Dto;

namespace ABP_CORE_MPA.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
