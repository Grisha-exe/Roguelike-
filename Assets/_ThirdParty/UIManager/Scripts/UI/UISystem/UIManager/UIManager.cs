using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Zenject;
using Enumerable = System.Linq.Enumerable;

namespace UIManager.UIManager
{
    [UsedImplicitly]
    public class UIManager : IUIManager
    {
        private List<object> _controllers = new();
        
#if EXTENJECT        
        private readonly DiContainer _container;
        public UIManager(DiContainer container)
        {
            _container = container;
        }
#endif
        public T LoadController<T>()
        {
            var existing = _controllers.OfType<T>().FirstOrDefault();
            
            if (existing != null)
            {
                return existing;
            }

#if EXTENJECT
            var controller = _container.Instantiate<T>();
#else  
            var controller = System.Activator.CreateInstance<T>();
#endif
            _controllers.Add(controller);
            return controller;
        }
    }
}