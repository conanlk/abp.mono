using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.Mono.Web;

[Dependency(ReplaceServices = true)]
public class MonoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Mono";
}
