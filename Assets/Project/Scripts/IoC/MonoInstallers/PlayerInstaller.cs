using UnityEngine;
using Zenject;

namespace Project.MonoInstallers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player _player;

        public override void InstallBindings()
        {
            Container
                .Bind<Player>()
                .FromInstance(_player)
                .AsSingle();
        }
    }
}