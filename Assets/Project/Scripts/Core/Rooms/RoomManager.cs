using System;
using Cysharp.Threading.Tasks;
using Project.Services.Factories;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Zenject;
using Object = UnityEngine.Object;

namespace Project
{
    public class RoomManager
    {
        public event Action<Room> OnRoomCreated;
        [Inject] private GlobalFactory _globalFactory;

        [SerializeField] private GameObject _roomPrefab;
        
        private Room _room;

        public async void Initialize()
        {
            _globalFactory.CreateRoomManagerContainer();
            _roomPrefab = await Addressables.LoadAssetAsync<GameObject>("TestRoom");
            _room = Object.Instantiate(_roomPrefab).GetComponent<Room>();
            OnRoomCreated?.Invoke(_room);
        }

        
    }
}