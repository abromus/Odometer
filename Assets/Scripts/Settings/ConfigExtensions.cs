namespace Odometer.Settings
{
    public static class ConfigExtensions
    {
        public static IUiFactoryConfig GetUiFactoryConfig(this IConfigStorage configStorage)
        {
            return configStorage.GetConfig<IUiFactoryConfig>();
        }
    }
}
