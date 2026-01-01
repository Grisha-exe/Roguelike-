using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player _player;
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private PlayerMovement _playerMovement;
        [SerializeField] private PlayerStats _playerStats;

        public override void InstallBindings()
        {
            Container
                .Bind<Player>()
                .FromInstance(_player)
                .AsSingle();
            Container
                .Bind<PlayerInput>()
                .FromInstance(_playerInput)
                .AsSingle();
            Container
                .Bind<PlayerMovement>()
                .FromInstance(_playerMovement)
                .AsSingle();
            Container
                .Bind<PlayerStats>()
                .FromInstance(_playerStats)
                .AsSingle();
        }
    }
}