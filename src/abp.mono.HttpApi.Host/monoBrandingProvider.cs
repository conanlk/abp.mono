using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace abp.mono;

[Dependency(ReplaceServices = true)]
public class monoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "mono";
}
