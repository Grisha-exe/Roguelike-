using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player _player;
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private PlayerStats _playerStats;
        [SerializeField] private PlayerController _playerController;

        public override void InstallBindings()
        {
            Container
                .Bind<Player>()
                .FromInstance(_player)
                .AsSingle();
            
            Container
                .Bind<PlayerStats>()
                .FromInstance(_playerStats)
                .AsSingle();
            
            Container
                .Bind<PlayerController>()
                .FromInstance(_playerController)
                .AsSingle();
        }
    }
}