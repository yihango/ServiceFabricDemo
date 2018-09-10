using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_CORE_MPA.Authorization.Accounts.Dto;

namespace ABP_CORE_MPA.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
