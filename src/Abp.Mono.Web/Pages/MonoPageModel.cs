using Abp.Mono.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.Mono.Web.Pages;

public abstract class MonoPageModel : AbpPageModel
{
    protected MonoPageModel()
    {
        LocalizationResourceType = typeof(MonoResource);
    }
}
