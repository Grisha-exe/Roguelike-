using System.Collections.Generic;
using Zenject;

namespace Project
{
    public class PlayerStats
    {
        public float MaxSpeed = 2f;
        public float Damage = 3.5f;
        public float ShootSpeed = 1.5f;
        public float Range = 6f;
        public float AttackSpeed = 4f;
        
        public int Coins = 0;
        public int Bombs = 0;
        public int Keys = 0;
        public string CoinsName = "Coin";
        public string KeysName = "Key";
        public string BombsName = "Bomb";
        
    }
}