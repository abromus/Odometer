using UnityEngine;

namespace Odometer.Settings
{
    [CreateAssetMenu(fileName = nameof(ServerConfig), menuName = ConfigKeys.PathKey + nameof(ServerConfig))]
    public sealed class ServerConfig : ScriptableObject, IServerConfig
    {
        [SerializeField] private string _ipAddress;
        [SerializeField] private int _port;

        public string IpAddress => _ipAddress;

        public int Port => _port;
    }
}

