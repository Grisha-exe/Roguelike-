namespace Project.States
{
    public class GameMetaState
    {
        public class GameCoreState : FsmStateBase
        {
            private  readonly Meta _meta;
        
            public GameCoreState(Fsm fsm, Meta meta) : base(fsm)
            {
                _meta = meta;
            }

            public override void Enter()
            {
                _meta.Initialize();
            }
        }
    }
}