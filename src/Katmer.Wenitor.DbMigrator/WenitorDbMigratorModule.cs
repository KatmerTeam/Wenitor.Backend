using Katmer.Wenitor.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Katmer.Wenitor.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(WenitorEntityFrameworkCoreDbMigrationsModule),
        typeof(WenitorApplicationContractsModule)
        )]
    public class WenitorDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<BackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
