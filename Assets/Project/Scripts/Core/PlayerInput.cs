using System;
using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerInput
    {
        private readonly InputSystem_Actions _inputSystem = new InputSystem_Actions();
        
        [Inject] PlayerController _playerController;

        public Vector2 MoveDirection { get; private set; }
        public Vector2 ShootDirection { get; private set; }

        private PlayerInput()
        {
            _inputSystem.Enable();
            
            _inputSystem.GamePlay.Move.performed += ctx => MoveDirection = ctx.ReadValue<Vector2>();
            _inputSystem.GamePlay.Move.canceled += ctx => MoveDirection = Vector2.zero;
            
            _inputSystem.GamePlay.Shoot.performed += ctx => ShootDirection = ctx.ReadValue<Vector2>();
            _inputSystem.GamePlay.Shoot.canceled += ctx => ShootDirection = Vector2.zero;

            _inputSystem.GamePlay.UseBomb.performed += ctx => _playerController.UseBomb();
        }
    }
}