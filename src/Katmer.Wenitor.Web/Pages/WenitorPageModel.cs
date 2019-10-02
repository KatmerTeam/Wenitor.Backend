using Katmer.Wenitor.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Katmer.Wenitor.Web.Pages
{
    public abstract class WenitorPageModel : AbpPageModel
    {
        protected WenitorPageModel()
        {
            LocalizationResourceType = typeof(WenitorResource);
        }
    }
}