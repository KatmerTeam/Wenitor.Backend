using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Katmer.Wenitor.Data
{
    /* This is used if database provider does't define
     * IWenitorDbSchemaMigrator implementation.
     */
    public class NullWenitorDbSchemaMigrator : IWenitorDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}