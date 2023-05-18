using Odometer.Factories;
using Odometer.Services;

namespace Odometer.States
{
    public sealed class LoopState : IEnterState
    {
        private readonly IData _data;

        private ISceneController _sceneController;

        public LoopState(IData data)
        {
            _data = data;
        }

        public void Enter()
        {
            var sceneControllerFactory = _data.FactoryStorage.GetSceneControllerFactory();
            _sceneController = sceneControllerFactory.Create();

            _sceneController.Run(_data);
        }

        public void Exit() { }
    }
}
