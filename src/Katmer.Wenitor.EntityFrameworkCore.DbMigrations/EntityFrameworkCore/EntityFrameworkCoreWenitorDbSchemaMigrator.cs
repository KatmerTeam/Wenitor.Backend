using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Katmer.Wenitor.Data;
using Volo.Abp.DependencyInjection;

namespace Katmer.Wenitor.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreWenitorDbSchemaMigrator 
        : IWenitorDbSchemaMigrator, ITransientDependency
    {
        private readonly WenitorMigrationsDbContext _dbContext;

        public EntityFrameworkCoreWenitorDbSchemaMigrator(WenitorMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}