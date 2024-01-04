using Volo.Abp.Settings;

namespace abp.mono.Settings;

public class monoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(monoSettings.MySetting1));
    }
}
