using Katmer.Wenitor.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Katmer.Wenitor.Permissions
{
    public class WenitorPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WenitorPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(WenitorPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WenitorResource>(name);
        }
    }
}
