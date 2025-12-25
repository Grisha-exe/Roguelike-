using Project.Services.Factories;
using UnityEngine;
using Zenject;

namespace Project
{
    public class Core
    {
        public static Core Instance;
        
        [Inject] private GlobalFactory _globalFactory;
        [Inject] private RoomManager _roomManager;
        
        private bool _isAcualGameState;
        private bool _isPossibleInteract;

        private GameObject _coreContainer;


        public void Initialize()
        {
            Core.Instance = this;
            
            _isAcualGameState = true;
            _isPossibleInteract = true;

            _coreContainer = _globalFactory.CreateCoreContainer();
            _roomManager.Initialize();
        }
        
        
    }
}