using System;
using UnityEngine;
using UnityEngine.UI;

namespace Project
{
    public class Player : MonoBehaviour
    {
        private readonly InputSystem_Actions _inputSystem = new();
        private Vector2 _moveInput;
        private Vector2 _shootInput;
        
        private int _health;
        private int _coins;
        private int _bombs;
        private int _keys;
        private float _moveSpeed;
        private float _damage;
        private float _fireRate;
        private float _fireRange;
        private float _bulletSpeed;

        public void Awake()
        {
            _inputSystem.GamePlay.Move.performed += ctx => _moveInput = ctx.ReadValue<Vector2>();
            _inputSystem.GamePlay.Move.canceled += ctx => _moveInput = Vector2.zero;
            
            _inputSystem.GamePlay.Shoot.performed += ctx => _shootInput = ctx.ReadValue<Vector2>();
            _inputSystem.GamePlay.Shoot.canceled += ctx => _shootInput = Vector2.zero;

            _inputSystem.GamePlay.UseBomb.performed += ctx => UseBomb();
            _inputSystem.GamePlay.UseActiveItem.performed += ctx => UseActiveItem();
            _inputSystem.GamePlay.Droptrinketsandconsumebles.performed += ctx => Drop();
            
        }

        private void OnEnable()
        {
            _inputSystem.Enable();
        }

        private void OnDisable()
        {
            _inputSystem.Disable();
        }

        public void Update()
        {
            Vector2 direction = new Vector2(_moveInput.x, _moveInput.y);
            transform.Translate(direction * _moveSpeed * Time.deltaTime);
        }

        public void Walk()
        {
            
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