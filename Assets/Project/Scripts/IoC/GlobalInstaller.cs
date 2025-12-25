using Project.Services.Factories;
using UIManager;
using Zenject;

namespace Project
{
    public class GlobalInstaller : MonoInstaller<GlobalInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindUIManager();
                
            Container
                .Bind<Meta>()
                .AsSingle();

            Container
                .Bind<Core>()
                .AsSingle();

            Container
                .Bind<GlobalFactory>()
                .AsSingle();

            Container
                .Bind<Main>()
                .AsSingle();
            Container 
                .Bind<CameraController>()
                .AsSingle();
            Container
                .Bind<RoomManager>()
                .AsSingle();
        }
    }
}