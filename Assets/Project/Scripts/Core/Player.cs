using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player : MonoBehaviour, IMovable
    {
        [Inject] private PlayerInput _playerInput;

        private Rigidbody2D _rigidbody;
        
        public void Update()
        {
            Move();
        }

        public void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        public void Move()
        {
            _rigidbody.velocity = _playerInput.MoveDirection * 2;
        }
    }
}