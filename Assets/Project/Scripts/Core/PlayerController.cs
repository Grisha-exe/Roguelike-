using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Zenject;

namespace Project
{
    public class PlayerController : IMovable
    {
        [Inject] private PlayerInput _playerInput;
        [Inject] private PlayerStats _playerStats;
        [Inject] private Player _player;

        [SerializeField] private GameObject _bombPrefab;
        
        private const  float Acceleration = 6.5f;
        private const float Deceleration = 6f;
        
        private Vector2 _velocity;
        private PickUp _pickUp;
        
        public void Move()
        {
            Vector2 targetVelocity = _playerInput.MoveDirection * _playerStats.MaxSpeed;
            _velocity = Vector2.MoveTowards(_player.Rigidbody.linearVelocity,
                targetVelocity, Acceleration * Time.deltaTime);

            _player.Rigidbody.linearVelocity = _velocity;
        }

        public void Shoot()
        {
            
        }

        public async void UseBomb()
        {
            if (_playerStats.Bombs == 0)
            {
                return;
            }

            _bombPrefab = await Addressables.LoadAssetAsync<GameObject>("BombPrefab");
            
            _pickUp = Object.Instantiate(_bombPrefab, _player.Transform.position, Quaternion.identity).GetComponent<PickUp>();
        }

        public void UseActiveItem()
        {
            
        }

        public void Drop()
        {
            
        }
    }
}