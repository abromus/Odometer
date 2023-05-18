namespace Odometer.Factories
{
    public interface IUiFactory : IFactory
    {
        public UiFactoryType UiFactoryType { get; }
    }
}
