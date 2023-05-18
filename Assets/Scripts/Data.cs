using Odometer.Services;
using Odometer.Settings;

namespace Odometer
{
    public sealed class Data : IData
    {
        private readonly IConfigStorage _configStorage;
        private readonly IFactoryStorage _factoryStorage;
        private readonly IServiceStorage _serviceStorage;

        public IConfigStorage ConfigStorage => _configStorage;

        public IFactoryStorage FactoryStorage => _factoryStorage;

        public IServiceStorage ServiceStorage => _serviceStorage;

        public Data(IConfigStorage configStorage)
        {
            _configStorage = configStorage;

            _factoryStorage = new FactoryStorage(configStorage);

            _serviceStorage = new ServiceStorage(this);
        }

        public void Destroy()
        {
            _factoryStorage.Destroy();

            _serviceStorage.Destroy();
        }
    }
}
