using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Katmer.Wenitor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Katmer.Wenitor.Web.Pages
{
    public abstract class WenitorPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<WenitorResource> L { get; set; }
    }
}
