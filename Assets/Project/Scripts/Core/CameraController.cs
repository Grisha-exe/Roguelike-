using System;
using UnityEngine;
using Zenject;

namespace Project
{
    public class CameraController : MonoBehaviour
    {
        [Inject] RoomManager _roomManager;
        
        public static CameraController Instance;


        private void Awake()
        {
            Instance = this;

            _roomManager.OnRoomCreated += SetRoom;
        }

        public void SetRoom(Room room)
        {
            
        }
    }
}