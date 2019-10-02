using Volo.Abp.Modularity;

namespace Katmer.Wenitor
{
    [DependsOn(
        typeof(WenitorApplicationModule),
        typeof(WenitorDomainTestModule)
        )]
    public class WenitorApplicationTestModule : AbpModule
    {

    }
}