using UnityEngine;

namespace Odometer.Factories
{
    public abstract class UiFactory : MonoBehaviour, IUiFactory
    {
        public abstract UiFactoryType UiFactoryType { get; }

        public abstract void Destroy();
    }
}
