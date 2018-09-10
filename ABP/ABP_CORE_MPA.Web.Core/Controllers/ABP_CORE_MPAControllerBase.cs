using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABP_CORE_MPA.Controllers
{
    public abstract class ABP_CORE_MPAControllerBase: AbpController
    {
        protected ABP_CORE_MPAControllerBase()
        {
            LocalizationSourceName = ABP_CORE_MPAConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
