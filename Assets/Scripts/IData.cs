using Odometer.Services;
using Odometer.Settings;

namespace Odometer
{
    public interface IData
    {
        public IConfigStorage ConfigStorage { get; }

        public IFactoryStorage FactoryStorage { get; }

        public IServiceStorage ServiceStorage { get; }

        public void Destroy();
    }
}
