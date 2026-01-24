using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerController : IMovable
    {
        [Inject] private PlayerInput _playerInput;
        [Inject] private PlayerStats _playerStats;
        [Inject] private Player _player;
        
        private const  float Acceleration = 6.5f;
        private const float Deceleration = 6f;
        
        private Vector2 _velocity;
        
        public void Move()
        {
            Vector2 targetVelocity = _playerInput.MoveDirection * _playerStats.MaxSpeed;
            _velocity = Vector2.MoveTowards(_player.Rigidbody.linearVelocity,
                targetVelocity, Acceleration * Time.deltaTime);

            _player.Rigidbody.linearVelocity = _velocity;
        }

        public void Shoot()
        {
            
        }

        public void UseBomb()
        {
            
        }

        public void UseActiveItem()
        {
            
        }

        public void Drop()
        {
            
        }
    }
}