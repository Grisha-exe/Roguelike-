using Project.Services.Factories;
using UnityEngine;
using Zenject;

namespace Project
{
    public class MainSceneBoot : MonoBehaviour
    {
        [Inject] private GlobalFactory _globalFactory;
        [Inject] private Main _main;

        [SerializeField] private bool _isTestBuild;
        
        private void Start()
        {
            Boot();
        }

        private void Boot()
        {
            _globalFactory.Initialize();
            
            _main.Initialize();
        }
    }
}