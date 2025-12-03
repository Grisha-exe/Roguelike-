using UnityEngine;

namespace Project.Services.Factories
{
    public class GlobalFactory
    {
        private GameObject _coreContainer;

        public void Initialize()
        {
            
        }

        public GameObject CreateCoreContainer()
        {
            _coreContainer = new GameObject("CoreContainer");
            return _coreContainer;
        }
    }
}