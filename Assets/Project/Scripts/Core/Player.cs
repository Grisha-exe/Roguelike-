using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player : MonoBehaviour , IMovable
    {
        [Inject] private PlayerInput _playerInput;

        public void Update()
        {
            Move();
        }

        public void Move()
        {
            transform.Translate(_playerInput.MoveDirection * 2 * Time.deltaTime);
        }
    }
}