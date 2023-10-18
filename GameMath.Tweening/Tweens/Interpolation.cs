﻿namespace GameMath.Tweening.Tweens
{
    abstract class Interpolation
    {
        public Ease? EaseingFunction { get; set; }
        protected Interpolation() { }
        protected Interpolation(Ease easeingFunction)
        {
            EaseingFunction = easeingFunction;
        }

        public abstract dynamic Interpolate(Tween tween, double currentDuration);
        public abstract Vectors.Vector2D Interpolate2D(Tween tween, double currentDuration);
    }
}
