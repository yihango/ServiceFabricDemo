using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_CORE_MPA.Configuration;

namespace ABP_CORE_MPA.Web.Startup
{
    [DependsOn(typeof(ABP_CORE_MPAWebCoreModule))]
    public class ABP_CORE_MPAWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABP_CORE_MPAWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ABP_CORE_MPANavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABP_CORE_MPAWebMvcModule).GetAssembly());
        }
    }
}
