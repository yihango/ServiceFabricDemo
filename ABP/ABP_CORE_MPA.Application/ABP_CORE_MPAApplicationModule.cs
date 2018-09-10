using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_CORE_MPA.Authorization;

namespace ABP_CORE_MPA
{
    [DependsOn(
        typeof(ABP_CORE_MPACoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABP_CORE_MPAApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABP_CORE_MPAAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABP_CORE_MPAApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
