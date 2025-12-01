using Cysharp.Threading.Tasks;
using JetBrains.Annotations;
using UnityEngine;
using Object = UnityEngine.Object;

namespace UIManager.Factories
{
    [UsedImplicitly]
    public static class UIViewFactory
    {
#if ADDRESSABLES
        public static async UniTask<T> LoadFromAddressablesAsync<T>(UIManagerCanvasBase parentCanvas, string assetPath) where T : UIViewBase
        {
            var assetLoader = new AssetLoader();
            
            var instance = await assetLoader.Load<T>(assetPath);

            instance = instance.GetComponent<T>();

            var viewInstance = Object.Instantiate(instance, parentCanvas.transform);
            
            return viewInstance;
        }
#endif
        public static T LoadFromResources<T>(UIManagerCanvasBase parentCanvas, string assetPath)
            where T : UIViewBase
        {
            var resourceRequest = Resources.LoadAsync<T>(assetPath);

            T viewInstance;

            if (parentCanvas != null)
            {
                viewInstance = Object.Instantiate(resourceRequest.asset, parentCanvas.transform) as T;
            }
            else
            {
                viewInstance = Object.Instantiate(resourceRequest.asset, parentCanvas.transform) as T;
            }

            return viewInstance;
        }
    }
}