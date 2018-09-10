using Abp.AutoMapper;
using ABP_CORE_MPA.Sessions.Dto;

namespace ABP_CORE_MPA.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
