using Odometer.Factories;

namespace Odometer.Services
{
    public interface IFactoryStorage
    {
        public void AddFactory<TFactory>(TFactory factory) where TFactory : class, IFactory;

        public void Destroy();

        public TFactory GetFactory<TFactory>() where TFactory : class, IFactory;
    }
}
