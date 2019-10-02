using Volo.Abp.Settings;

namespace Katmer.Wenitor.Settings
{
    public class WenitorSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            context.Add(new SettingDefinition(WenitorSettings.MySetting1));
        }
    }
}
