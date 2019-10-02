using Katmer.Wenitor.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Katmer.Wenitor.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class WenitorController : AbpController
    {
        protected WenitorController()
        {
            LocalizationResource = typeof(WenitorResource);
        }
    }
}