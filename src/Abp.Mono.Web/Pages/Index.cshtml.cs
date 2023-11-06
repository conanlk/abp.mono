using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Abp.Mono.Web.Pages;

public class IndexModel : MonoPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
