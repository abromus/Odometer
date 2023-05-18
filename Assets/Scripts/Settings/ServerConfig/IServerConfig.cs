namespace Odometer.Settings
{
    public interface IServerConfig : IConfig
    {
        public string IpAddress { get; }

        public int Port { get; }
    }
}
