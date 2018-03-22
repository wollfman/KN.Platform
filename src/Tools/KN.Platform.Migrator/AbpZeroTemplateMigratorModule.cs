using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using KN.Platform;
using KN.Platform.EntityFramework;

namespace KN.Platform.Migrator
{
    [DependsOn(typeof(AbpZeroTemplateDataModule))]
    public class AbpZeroTemplateMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpZeroTemplateDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}