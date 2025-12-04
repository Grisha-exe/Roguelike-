using Project.Services.Factories;
using UnityEngine;
using Zenject;

namespace Project
{
    public class Core
    {
        [Inject] private GlobalFactory _globalFactory;
        private bool _isAcualGameState;
        private bool _isPossibleInteract;

        private GameObject _coreContainer;

        public void Initialize()
        {
            _isAcualGameState = true;
            _isPossibleInteract = true;

            _coreContainer = _globalFactory.CreateCoreContainer();
        }

        
    }
}