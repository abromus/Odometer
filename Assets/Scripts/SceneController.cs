using UnityEngine;

namespace Odometer
{
    public sealed class SceneController : MonoBehaviour, ISceneController
    {
        [SerializeField] private Camera _cameraPrefab;

        private Camera _camera;

        public void Run(IData data) { }

        public void Destroy() { }

        private void Awake()
        {
            _camera = Instantiate(_cameraPrefab);
            _camera.transform.SetAsFirstSibling();
        }

        private void OnDestroy()
        {
            Destroy();
        }
    }
}
