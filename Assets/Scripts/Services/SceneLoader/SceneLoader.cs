using System;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace Odometer.Services
{
    public sealed class SceneLoader : ISceneLoader, IService
    {
        public void Load(string name, Action success)
        {
            LoadScene(name, success);
        }

        public void Destroy() { }

        private async void LoadScene(string name, Action success = null)
        {
            if (SceneManager.GetActiveScene().name != name)
            {
                var operation = SceneManager.LoadSceneAsync(name);

                await UniTask.WaitUntil(() => operation.isDone);
            }

            success.SafeInvoke();
        }
    }
}
