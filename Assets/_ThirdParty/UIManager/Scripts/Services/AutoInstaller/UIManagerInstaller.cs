#if EXTENJECT

using System;
using System.Linq;
using System.Reflection;
using UIManager.UIManager;
using Zenject;

namespace UIManager
{
    public static class UIManagerInstaller
    {
        public static void BindUIManager(this DiContainer container, Assembly assembly = null)
        {
            container.Bind<IUIManager>()
                .To<UIManager.UIManager>()
                .AsSingle();
            
            assembly ??= Assembly.GetExecutingAssembly();
            
            var controllerTypes = assembly.GetTypes()
                .Where(t =>
                    t.IsClass &&
                    !t.IsAbstract &&
                    InheritsFromGeneric(t, typeof(UIControllerBase<>)))
                .ToList();

            foreach (var type in controllerTypes)
            {
                container.Bind(type).AsSingle();
            }
        }

        private static bool InheritsFromGeneric(Type type, Type generic)
        {
            while (type != null && type != typeof(object))
            {
                var cur = type.IsGenericType ? type.GetGenericTypeDefinition() : type;
                if (generic == cur)
                    return true;

                type = type.BaseType;
            }
            return false;
        }
    }
}

#endif