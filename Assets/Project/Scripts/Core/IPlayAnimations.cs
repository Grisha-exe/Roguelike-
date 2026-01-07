using UnityEngine;

namespace Project
{
    public interface IPlayAnimations
    {
        public void PlayAnimation(string VerticalAnimation, string HorizontalAnimation);
        
        public void IdleAnimation();
    }
}