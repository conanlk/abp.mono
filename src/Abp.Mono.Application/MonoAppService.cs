using System;
using System.Collections.Generic;
using System.Text;
using Abp.Mono.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Mono;

/* Inherit your application services from this class.
 */
public abstract class MonoAppService : ApplicationService
{
    protected MonoAppService()
    {
        LocalizationResource = typeof(MonoResource);
    }
}
