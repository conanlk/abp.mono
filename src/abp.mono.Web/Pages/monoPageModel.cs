using abp.mono.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace abp.mono.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class monoPageModel : AbpPageModel
{
    protected monoPageModel()
    {
        LocalizationResourceType = typeof(monoResource);
    }
}
