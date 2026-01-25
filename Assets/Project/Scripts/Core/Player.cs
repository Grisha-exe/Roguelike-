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
        [Inject] private PlayerStats _playerStats;

        public Rigidbody2D Rigidbody;
        
        private BoxCollider2D _boxCollider;
        private string _verticalAnimationName;
        private string _horizontalAnimationName;

        public void Awake()
        {
            Rigidbody = GetComponent<Rigidbody2D>();
            Rigidbody.linearDamping = 0;
            _boxCollider = GetComponent<BoxCollider2D>();
        }

        public void Update()
        {
            _playerController.Move();
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
                if (other.CompareTag("Pickup"))
                {
                    var otherName = other.gameObject.name;
                    
                    Destroy(other.gameObject);
                }
        }
        
    }
}