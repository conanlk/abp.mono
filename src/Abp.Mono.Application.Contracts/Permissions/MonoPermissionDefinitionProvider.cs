using Abp.Mono.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.Mono.Permissions;

public class MonoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MonoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MonoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MonoResource>(name);
    }
}
