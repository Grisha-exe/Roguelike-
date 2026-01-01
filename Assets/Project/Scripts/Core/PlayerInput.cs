using System;
using UnityEngine;

namespace Project
{
    public class PlayerInput : MonoBehaviour, IGetDirection
    {
        private readonly InputSystem_Actions _inputSystem;

        private Vector2 _moveDirection;
        private Vector2 _shootDirection;

        private void Update()
        {
            GetMoveDirection(_moveDirection);
            GetShootDirevtion(_shootDirection);
        }

        private void OnEnable()
        {
            _inputSystem.Enable();
        }

        private void OnDisable()
        {
            _inputSystem.Disable();
        }

        public Vector2 GetMoveDirection(Vector2 _moveInput)
        {
            _inputSystem.GamePlay.Move.performed += ctx => _moveInput = ctx.ReadValue<Vector2>();
            _inputSystem.GamePlay.Move.canceled += ctx => _moveInput = Vector2.zero;
            return _moveInput;
        }

        public Vector2 GetShootDirevtion(Vector2 _shootInput)
        {
            _inputSystem.GamePlay.Shoot.performed += ctx => _shootInput = ctx.ReadValue<Vector2>();
            _inputSystem.GamePlay.Shoot.canceled += ctx => _shootInput = Vector2.zero;
            return _shootInput;
        }
    }
}