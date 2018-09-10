using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABP_CORE_MPA.MultiTenancy;

namespace ABP_CORE_MPA.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
