using UnityEngine;
using Zenject;

namespace Project
{
    public class PlayerMovement : MonoBehaviour
    {
        [Inject] private PlayerInput _playerInput;
        
        /*private void Update()
        {
            Vector2 direction = new Vector2(_moveInput.x, _moveInput.y);
            transform.Translate(direction * _moveSpeed * Time.deltaTime);
        }*/
    }
}