using System.Collections.Generic;
using System.Linq;
using Odometer.Services;

namespace Odometer.Factories
{
    public static class FactoryExtensions
    {
        public static ISceneControllerFactory GetSceneControllerFactory(this IFactoryStorage factoryStorage)
        {
            return factoryStorage.GetFactory<ISceneControllerFactory>();
        }

        public static ISceneControllerFactory GetSceneControllerFactory(this IReadOnlyList<IUiFactory> uiFactories)
        {
            return uiFactories.FirstOrDefault(factory => factory.UiFactoryType == UiFactoryType.SceneControllerFactory) as ISceneControllerFactory;
        }
    }
}
