using System.Collections.Generic;
using Odometer.Factories;

namespace Odometer.Settings
{
    public interface IUiFactoryConfig : IConfig
    {
        public IReadOnlyList<IUiFactory> UiFactories { get; }

        public void Destroy();
    }
}
