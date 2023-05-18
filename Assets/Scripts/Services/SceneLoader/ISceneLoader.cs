using System;

namespace Odometer.Services
{
    public interface ISceneLoader : IService
    {
        public void Load(string name, Action success);
    }
}
