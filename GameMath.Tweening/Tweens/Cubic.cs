﻿
namespace GameMath.Tweening
{
    internal class Cubic : EasingTween
    {
        protected override dynamic Interpolate(double currentTime)
        {
            return Ease.Interpolate(this, currentTime);
        }
    }
}
