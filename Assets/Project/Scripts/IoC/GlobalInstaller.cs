using Project.Services.Factories;
using UIManager;
using UnityEngine;
using Zenject;

namespace Project
{
    public class GlobalInstaller : MonoInstaller<GlobalInstaller>
    {
        [SerializeField] private Player _player;
        
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

            Container
                .Bind<Player>()
                .FromComponentInNewPrefab(_player)
                .AsSingle()
                .NonLazy();
            
            Container
                .Bind<PlayerInput>()
                .AsSingle();
        }
    }
}