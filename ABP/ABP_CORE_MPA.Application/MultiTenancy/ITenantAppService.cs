using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABP_CORE_MPA.MultiTenancy.Dto;

namespace ABP_CORE_MPA.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
