using UnityEngine;

namespace Project
{
    public class CameraController : MonoBehaviour
    {
        public static CameraController Instance;

        public int CameraZoomOut = -10; 

        private void Awake()
        {
            Instance = this;
        }

        public void SetRoom(Room room)
        {
            Vector3 camPos = room.transform.position;
            camPos.z = CameraZoomOut;
            transform.position = camPos;
        }
    }
}