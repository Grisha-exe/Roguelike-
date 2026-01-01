using UnityEngine;

namespace Project
{
    public interface IGetDirection
    {
        public Vector2 GetMoveDirection(Vector2 direction);
        
        public Vector2 GetShootDirevtion(Vector2 direction);
    }
}