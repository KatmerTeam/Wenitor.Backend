using Katmer.Wenitor.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Katmer.Wenitor
{
    [DependsOn(
        typeof(WenitorEntityFrameworkCoreTestModule)
        )]
    public class WenitorDomainTestModule : AbpModule
    {

    }
}