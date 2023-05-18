using UnityEngine;

namespace Odometer.Factories
{
    public sealed class SceneControllerFactory : UiFactory, ISceneControllerFactory
    {
        [SerializeField] private SceneController _sceneControllerPrefab;

        public override UiFactoryType UiFactoryType => UiFactoryType.SceneControllerFactory;

        public SceneController Create()
        {
            var sceneController = Instantiate(_sceneControllerPrefab);

            return sceneController;
        }

        public override void Destroy() { }
    }
}
