using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ABP_CORE_MPA.Web.Views
{
    public abstract class ABP_CORE_MPARazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABP_CORE_MPARazorPage()
        {
            LocalizationSourceName = ABP_CORE_MPAConsts.LocalizationSourceName;
        }
    }
}
