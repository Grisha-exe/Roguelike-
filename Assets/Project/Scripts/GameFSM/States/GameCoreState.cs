using Project.Core;

namespace Scripts.States
{
    public class GameCoreState : FsmStateBase
    {
        private  readonly Core _core;
        
        public GameCoreState(Fsm fsm, Core core) : base(fsm)
        {
            _core = core;
        }

        public override void Enter()
        {
            _core.Initialize();
        }
    }
}