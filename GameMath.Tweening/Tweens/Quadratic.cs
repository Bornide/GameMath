namespace GameMath.Tweening.Tweens
{
    class Quadratic<T> : EasingInterpolation<T>
    {
        public Quadratic(Ease<T> easeingFunction) : base(easeingFunction) { }

        public override T Interpolate(Tween<T> tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return EaseingFunction.Interpolate(this, tween, currentDuration);
        }
    }
}
