using Project.Services.Factories;
using Project.States;
using UnityEngine;
using Zenject;

namespace Project
{
    public class Main
    {
        [Inject] private Core _core;
        [Inject] private Meta _meta;
        [Inject] private GlobalFactory _globalFactory;

        private Fsm _gameFsm = new();

        public void Initialize()
        {
            _gameFsm.AddState(new GameCoreState(_gameFsm, _core));
            _gameFsm.AddState(new GameMetaState(_gameFsm, _meta));
            
            SetMetaState();
        }

        public void SetMetaState()
        {
            _gameFsm.SetState<GameMetaState>();
        }

        public void SetCoreState()
        {
            _gameFsm.SetState<GameCoreState>();
        }
    }
}