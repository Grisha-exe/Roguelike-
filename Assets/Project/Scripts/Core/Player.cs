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

        private string _verticalAnimationName;
        private string _horizontalAnimationName;

        public void Awake()
        {
            Rigidbody = GetComponent<Rigidbody2D>();
            Rigidbody.linearDamping = 0;
        }

        public void Update()
        {
            _playerController.Move();
        }
    }
}