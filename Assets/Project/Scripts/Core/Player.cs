using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player : MonoBehaviour
    {
        [Inject] private PlayerController _playerController;

        public Rigidbody2D Rigidbody;
        private Animator _animator;
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
            Rigidbody = GetComponent<Rigidbody2D>();
            Rigidbody.linearDamping = 0;
        }

        public void Update()
        {
            _playerController.Move();
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