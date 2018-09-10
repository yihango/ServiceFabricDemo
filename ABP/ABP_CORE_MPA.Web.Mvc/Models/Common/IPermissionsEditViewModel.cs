using System.Collections.Generic;
using ABP_CORE_MPA.Roles.Dto;

namespace ABP_CORE_MPA.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}