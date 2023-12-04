using abp.mono.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace abp.mono.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class monoController : AbpControllerBase
{
    protected monoController()
    {
        LocalizationResource = typeof(monoResource);
    }
}
