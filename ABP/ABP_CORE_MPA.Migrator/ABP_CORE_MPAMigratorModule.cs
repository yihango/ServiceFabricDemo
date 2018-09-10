using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_CORE_MPA.Configuration;
using ABP_CORE_MPA.EntityFrameworkCore;
using ABP_CORE_MPA.Migrator.DependencyInjection;

namespace ABP_CORE_MPA.Migrator
{
    [DependsOn(typeof(ABP_CORE_MPAEntityFrameworkModule))]
    public class ABP_CORE_MPAMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ABP_CORE_MPAMigratorModule(ABP_CORE_MPAEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ABP_CORE_MPAMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ABP_CORE_MPAConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABP_CORE_MPAMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
