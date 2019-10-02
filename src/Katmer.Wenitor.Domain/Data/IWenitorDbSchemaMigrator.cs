using System.Threading.Tasks;

namespace Katmer.Wenitor.Data
{
    public interface IWenitorDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
