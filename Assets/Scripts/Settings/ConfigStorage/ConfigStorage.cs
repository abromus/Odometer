using System;
using System.Collections.Generic;
using UnityEngine;

namespace Odometer.Settings
{
    [CreateAssetMenu(fileName = nameof(ConfigStorage), menuName = ConfigKeys.PathKey + nameof(ConfigStorage))]
    public sealed class ConfigStorage : ScriptableObject, IConfigStorage
    {
        [SerializeField] private ServerConfig _serverConfig;
        [SerializeField] private UiFactoryConfig _uiFactoryConfig;

        private Dictionary<Type, IConfig> _configs;

        public void Init()
        {
            _configs = new Dictionary<Type, IConfig>()
            {
                [typeof(IServerConfig)] = _serverConfig,
                [typeof(IUiFactoryConfig)] = _uiFactoryConfig,
            };
        }

        public void AddConfig<TConfig>(TConfig config) where TConfig : class, IConfig
        {
            var type = typeof(TConfig);

            if (_configs.ContainsKey(type))
                _configs[type] = config;
            else
                _configs.Add(type, config);
        }

        public TConfig GetConfig<TConfig>() where TConfig : class, IConfig
        {
            return _configs[typeof(TConfig)] as TConfig;
        }

        public void Destroy()
        {
            _configs.Clear();
            _configs = null;
        }
    }
}
