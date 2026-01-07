using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player : MonoBehaviour, IMovable, IPlayAnimations
    {
        private const float Acceleration = 6.5f;
        private const float Deceleration = 6f;

        [Inject] private PlayerInput _playerInput;

        public float MaxSpeed = 2f;

// 10,11,15 строчку перенести в playerstats потом.
        private Rigidbody2D _rigidbody;
        private Animator _animator;
        private Vector2 _velocity;
        private SpriteRenderer _spriteRenderer;

        private string VerticalAnimationName;
        private string _horizontalAnimationName;

        public void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
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

            if (_playerInput.MoveDirection != Vector2.zero)
            {
                if (_playerInput.MoveDirection.x > 0)
                {
                    Play(_horizontalAnimationName);
                }
                else
                {
                    _spriteRenderer.flipX = true;
                    Play(_horizontalAnimationName);
                }
            }
            else
            {
                Pause();
            }

            _rigidbody.linearVelocity = _velocity;
        }

        public void Play(string AnimationName)
        {
            _animator.Play(AnimationName);
        }

        public void Pause()
        {
            _animator.Play("Idle");
        }
    }
}