namespace Project.States
{
    public class GameMetaState : FsmStateBase
    {
            private  readonly Meta _meta;
        
            public GameMetaState(Fsm fsm, Meta meta) : base(fsm)
            {
                _meta = meta;
            }

            public override void Enter()
            {
                _meta.Initialize();
            }
        }
    }
