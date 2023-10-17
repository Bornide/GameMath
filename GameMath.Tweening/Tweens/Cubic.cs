﻿
namespace GameMath.Tweening
{
    internal class Cubic : EasingTween
    {
        protected override dynamic Interpolate(double currentTime)
        {
            if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return Ease.Interpolate(this, currentTime);
        }
    }
}
