using UnityEngine;

namespace Project
{
    public interface IPlayAnimations
    {
        public void Play(string animationName);
        
        public void Pause();
    }
}