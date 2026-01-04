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
        private Animator _animator;
        private Vector2 _velocity;

        public void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            _rigidbody = GetComponent<Rigidbody2D>();
            _rigidbody.linearDamping = 0;
        }

        public void Update()
        {
            Move();
        }

        public void Move()
        {
            Vector2 targetVelocity = _playerInput.MoveDirection * MaxSpeed;
                _velocity = Vector2.MoveTowards(_rigidbody.linearVelocity,
                    targetVelocity, Acceleration * Time.deltaTime);
                
            _rigidbody.linearVelocity = _velocity;
        }
    }
}