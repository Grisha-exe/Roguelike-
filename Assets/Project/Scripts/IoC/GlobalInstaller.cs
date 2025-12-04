using Project.Services.Factories;
using Zenject;

namespace Project
{
    public class GlobalInstaller : MonoInstaller<GlobalInstaller>
    {

        public override void InstallBindings()
        {
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
        }
    }
}