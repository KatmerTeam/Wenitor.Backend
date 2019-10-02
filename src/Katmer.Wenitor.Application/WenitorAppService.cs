using System;
using System.Collections.Generic;
using System.Text;
using Katmer.Wenitor.Localization;
using Volo.Abp.Application.Services;

namespace Katmer.Wenitor
{
    /* Inherit your application services from this class.
     */
    public abstract class WenitorAppService : ApplicationService
    {
        protected WenitorAppService()
        {
            LocalizationResource = typeof(WenitorResource);
        }
    }
}
