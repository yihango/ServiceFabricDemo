using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABP_CORE_MPA.Web.Views
{
    public abstract class ABP_CORE_MPAViewComponent : AbpViewComponent
    {
        protected ABP_CORE_MPAViewComponent()
        {
            LocalizationSourceName = ABP_CORE_MPAConsts.LocalizationSourceName;
        }
    }
}
