using Volo.Abp.Settings;

namespace Abp.Mono.Settings;

public class MonoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MonoSettings.MySetting1));
    }
}
