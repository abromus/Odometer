﻿using Odometer.Services;

namespace Odometer.States
{
    public sealed class SceneLoaderState : IEnterState<SceneInfo>
    {
        private readonly ISceneLoader _sceneLoader;

        public SceneLoaderState(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void Enter(SceneInfo sceneInfo)
        {
            _sceneLoader.Load(sceneInfo.Name, sceneInfo.Success);
        }

        public void Exit() { }
    }
}
