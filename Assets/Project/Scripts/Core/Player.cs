using System;
using DG.Tweening;
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
        /*
        private SpriteRenderer _spriteRenderer;
        */

        private string _verticalAnimationName;
        private string _horizontalAnimationName;

        public void Awake()
        {
            _animator = GetComponentInChildren<Animator>();
            /*
            _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            */
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
            /*
            PlayAnimation(_verticalAnimationName, _horizontalAnimationName);
            */

            _rigidbody.linearVelocity = _velocity;

            /*if (_playerInput.MoveDirection == Vector2.zero)
            {
                IdleAnimation();
            }*/
        }

        /*public void PlayAnimation(string VerticalAnimation, string HorizontalAnimation)
        {
            if (_playerInput.MoveDirection.y < 0)
            {
                _animator.Play(VerticalAnimation);
            }
            else if (_playerInput.MoveDirection.y > 0)
            {
                _animator.speed = -1f;
                _animator.Play(VerticalAnimation, 0, 1f);
            }
            else if (_playerInput.MoveDirection.x > 0)
            {
                _animator.Play(HorizontalAnimation);
            }
            else if (_playerInput.MoveDirection.x < 0)
            {
                _spriteRenderer.flipX = true;
                _animator.Play(HorizontalAnimation);
            }
        }*/


        /*public void IdleAnimation()
        {
            _animator.Play("Idle");
        }*/
    }
}