using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP_CORE_MPA.Configuration.Dto;

namespace ABP_CORE_MPA.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABP_CORE_MPAAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
