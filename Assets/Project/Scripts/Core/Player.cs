using System;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Project
{
    public class Player
    {
        [Inject] private PlayerMovement playerMovement;
        private PlayerMovement _movement;
        private PlayerStats _stats;
        
    }
}