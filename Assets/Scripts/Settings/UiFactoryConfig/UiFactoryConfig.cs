using System.Collections.Generic;
using Odometer.Factories;
using UnityEngine;

namespace Odometer.Settings
{
    [CreateAssetMenu(fileName = nameof(UiFactoryConfig), menuName = ConfigKeys.PathKey + nameof(UiFactoryConfig))]
    public sealed class UiFactoryConfig : ScriptableObject, IUiFactoryConfig
    {
        [SerializeField] private List<UiFactory> _uiFactories;

        public IReadOnlyList<IUiFactory> UiFactories => _uiFactories;

        public void Destroy() { }
    }
}
