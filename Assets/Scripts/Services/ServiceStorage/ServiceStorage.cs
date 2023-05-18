using System;
using System.Collections.Generic;
using Odometer.States;

namespace Odometer.Services
{
    public sealed class ServiceStorage : IServiceStorage
    {
        private Dictionary<Type, IService> _services;

        public ServiceStorage(IData data)
        {
            var stateMachine = InitStateMachine(data);

            _services = new Dictionary<Type, IService>()
            {
                [typeof(IStateMachine)] = stateMachine,
            };
        }

        public void Destroy()
        {
            foreach (var service in _services.Values)
                service.Destroy();

            _services.Clear();
            _services = null;
        }

        public void AddService<TService>(TService service) where TService : class, IService
        {
            var type = typeof(TService);

            if (_services.ContainsKey(type))
                _services[type] = service;
            else
                _services.Add(type, service);
        }

        public TService GetService<TService>() where TService : class, IService
        {
            return _services[typeof(TService)] as TService;
        }

        private IStateMachine InitStateMachine(IData data)
        {
            var stateMachine = new StateMachine();

            stateMachine.Add(new BootstrapState(stateMachine));
            stateMachine.Add(new SceneLoaderState(new SceneLoader()));
            stateMachine.Add(new LoopState(data));

            return stateMachine;
        }
    }
}
