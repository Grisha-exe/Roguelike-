using System;
using DG.Tweening;
using Project.Services.Enums;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player : MonoBehaviour
    {
        [Inject] private PlayerController _playerController;
        [Inject] private PlayerStats _playerStats;
        
        public Rigidbody2D Rigidbody; 
        public Transform Transform;
        
        private BoxCollider2D _boxCollider;
        private string _verticalAnimationName;
        private string _horizontalAnimationName;
        

        public void Awake()
        {
            Rigidbody = GetComponent<Rigidbody2D>();
            Rigidbody.linearDamping = 0;
            Transform = GetComponent<Transform>();
            _boxCollider = GetComponent<BoxCollider2D>();
        }

        public void Update()
        {
            _playerController.Move();
            _playerController.Shoot();
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
                if (!other.CompareTag("PickUp"))
                {
                    return;
                }
                
                var pickup = other.GetComponent<PickUp>();
                
                if (pickup == null) return;

                switch (pickup.Type)
                {
                    case PickUpType.Coin:
                        _playerStats.Coins++;
                        break;

                    case PickUpType.Key:
                        _playerStats.Keys++;
                        break;

                    case PickUpType.Bomb:
                        _playerStats.Bombs++;
                        break;
                }

                Destroy(other.gameObject);
        }
        
    }
}