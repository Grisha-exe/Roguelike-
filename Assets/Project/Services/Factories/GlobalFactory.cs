using UnityEngine;

namespace Project.Services.Factories
{
    public class GlobalFactory
    {
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
    }
}