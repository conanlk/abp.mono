using abp.mono.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abp.mono.Permissions;

public class monoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(monoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(monoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<monoResource>(name);
    }
}
