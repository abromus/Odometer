using Odometer.Services;
using Odometer.Settings;
using Odometer.States;
using UnityEngine;

namespace Odometer
{
    public sealed class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private ConfigStorage _configStorage;

        private IData _data;

        private void Awake()
        {
            _configStorage.Init();

            _data = new Data(_configStorage);

            EnterInitState();

            DontDestroyOnLoad(this);
        }

        private void Destroy()
        {
            _data.Destroy();
        }

        private void EnterInitState()
        {
            _data.ServiceStorage.GetStateMachine().Enter<BootstrapState>();
        }

        private void OnDestroy()
        {
            Destroy();
        }
    }
}
