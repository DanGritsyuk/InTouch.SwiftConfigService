using MessagePack;

namespace InTouch.SwiftConfigService.Entities.Common
{
    [MessagePackObject]
    public abstract class SettingsRecord
    {
        public virtual string Code => GetType().Name;
    }
}