using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Katmer.Wenitor.Web
{
    [Dependency(ReplaceServices = true)]
    public class WenitorBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Wenitor";
    }
}
