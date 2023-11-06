using Abp.Mono.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Mono.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MonoController : AbpControllerBase
{
    protected MonoController()
    {
        LocalizationResource = typeof(MonoResource);
    }
}
