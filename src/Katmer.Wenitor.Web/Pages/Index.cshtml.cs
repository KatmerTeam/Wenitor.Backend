using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Katmer.Wenitor.Web.Pages
{
    public class IndexModel : WenitorPageModel
    {
        public void OnGet()
        {
            
        }

        public async Task OnPostLoginAsync()
        {
            await HttpContext.ChallengeAsync("oidc");
        }
    }
}