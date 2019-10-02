using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Katmer.Wenitor.EntityFrameworkCore
{
    [DependsOn(
        typeof(WenitorEntityFrameworkCoreModule)
        )]
    public class WenitorEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WenitorMigrationsDbContext>();
        }
    }
}
