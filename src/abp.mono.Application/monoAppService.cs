using System;
using System.Collections.Generic;
using System.Text;
using abp.mono.Localization;
using Volo.Abp.Application.Services;

namespace abp.mono;

/* Inherit your application services from this class.
 */
public abstract class monoAppService : ApplicationService
{
    protected monoAppService()
    {
        LocalizationResource = typeof(monoResource);
    }
}
