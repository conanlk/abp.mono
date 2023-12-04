using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace abp.mono.Web;

[Dependency(ReplaceServices = true)]
public class monoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "mono";
}
