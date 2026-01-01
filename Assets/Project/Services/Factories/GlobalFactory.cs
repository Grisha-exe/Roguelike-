using UIManager.UIManager;
using UnityEngine;
using Zenject;

namespace Project.Services.Factories
{
    public class GlobalFactory
    {
        [Inject] private IUIManager _uiManager;

        private GameObject _coreContainer;
        private GameObject _metaContainer;
        private GameObject _roomManagerContainer;
        private GameObject _playerContainer;

        public void Initialize()
        {
            
        }

        public GameObject CreatePlayerManager()
        {
            _playerContainer = new GameObject("Player");
            return _playerContainer;
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

        public GameObject CreateRoomManagerContainer()
        {
            _roomManagerContainer = new GameObject("RoomManagerContainer");
            return _roomManagerContainer; 
        }
    }
}