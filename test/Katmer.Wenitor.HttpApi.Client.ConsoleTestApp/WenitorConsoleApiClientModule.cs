using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Katmer.Wenitor.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(WenitorHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class WenitorConsoleApiClientModule : AbpModule
    {
        
    }
}
