using UIManager.UIManager;
using UnityEngine;
using Zenject;

namespace Project.Services.Factories
{
    public class GlobalFactory
    {
        [Inject] private IUIManager _uiManager;

        private GameObject _room;
        private GameObject _coreContainer;
        private GameObject _metaContainer;

        public void Initialize()
        {
            
        }

        public GameObject CreateCoreContainer()
        {
            _coreContainer = new GameObject("CoreContainer");
            return _coreContainer;
        }

        public GameObject CreateMetaContainer()
        {
            _metaContainer = new GameObject("MetaContainer");
            return _metaContainer;
        }

        public GameObject CreateRoom()
        {
            _room = new GameObject("Room");
            return _room;
        }
    }
}