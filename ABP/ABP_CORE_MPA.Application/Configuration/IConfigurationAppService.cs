using System.Threading.Tasks;
using ABP_CORE_MPA.Configuration.Dto;

namespace ABP_CORE_MPA.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
