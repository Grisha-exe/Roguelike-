using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player : MonoBehaviour, IMovable
    {
        private const float Acceleration = 6.5f;
        private const float Deceleration = 6f;
        
        [Inject] private PlayerInput _playerInput;
        
        public float MaxSpeed = 2f;
// 10,11,15 строчку перенести в playerstats потом.
        private Rigidbody2D _rigidbody;
        private Vector2 _velocity;
        
        public void Update()
        {
            Move();
        }

        public void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.linearDamping = 0;
        }

        public void Move()
        {
            Vector2 targetVelocity = _playerInput.MoveDirection * MaxSpeed;
            if (_playerInput != null)
            {
                _velocity = Vector2.MoveTowards(_rigidbody.linearVelocity, 
                    targetVelocity, Acceleration * Time.deltaTime);
            }
            else
            {
                _velocity = Vector2.MoveTowards(_rigidbody.linearVelocity,
                    Vector2.zero, Deceleration * Time.deltaTime);
            }
            
            _rigidbody.linearVelocity = _velocity;
        }
    }
}