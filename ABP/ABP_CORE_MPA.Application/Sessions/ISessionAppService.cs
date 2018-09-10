using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_CORE_MPA.Sessions.Dto;

namespace ABP_CORE_MPA.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
