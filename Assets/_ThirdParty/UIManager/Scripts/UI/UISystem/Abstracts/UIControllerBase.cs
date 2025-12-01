using System;
using System.Linq;
using System.Threading.Tasks;
using UIManager.Attributes;
using UIManager.Factories;

namespace UIManager
{
    public abstract class UIControllerBase<TView> where TView : UIViewBase
    {
        protected TView View;

        private bool _isViewLoaded;
        protected abstract UIManagerCanvasBase ParentCanvas { get; set; }

        protected UIControllerBase()
        {
#if ADDRESSABLES
            LoadFromAddressables();
#else
            LoadFromResources();
#endif
        }

#if ADDRESSABLES
        private async void LoadFromAddressables()
        {
            View = await UIViewFactory.LoadFromAddressablesAsync<TView>(ParentCanvas, GetViewAssetAddress());
            
            View.gameObject.SetActive(false);
            _isViewLoaded = true;

            Initialize();
        }
#endif
        private void LoadFromResources()
        {
            View = UIViewFactory.LoadFromResources<TView>(ParentCanvas, GetViewAssetAddress());
            
            View.gameObject.SetActive(false);
            _isViewLoaded = true;

            Initialize();
        }

        public async void Open()
        {
            if (!_isViewLoaded)
            {
                await WaitForViewToLoad();
            }

            View.gameObject.SetActive(true);
            OnOpen();
        }

        public async void Close()
        {
            if (!_isViewLoaded)
            {
                await WaitForViewToLoad();
            }

            OnClose();
            View.gameObject.SetActive(false);
        }

        protected abstract void Initialize();

        protected virtual void OnOpen() { }

        protected virtual void OnClose() { }

        private async Task WaitForViewToLoad()
        {
            while (!_isViewLoaded)
            {
                await Task.Yield();
            }
        }

        private string GetViewAssetAddress()
        {
            var type = GetType();

            var attribute = type.GetCustomAttributes(typeof(AssetAddress), false)
                .FirstOrDefault() as AssetAddress;

            return attribute?.Address ?? throw new ArgumentException($"Cannot find Address of {type}");
        }
    }
}