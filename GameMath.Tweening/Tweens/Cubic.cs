namespace GameMath.Tweening.Tweens
{
    internal class Cubic<T> : EasingInterpolation<T>
    {
        public Cubic() : base() { }
        public Cubic(Ease<T> easeingFunction) : base(easeingFunction) { }

        public override T Interpolate(Tween<T> tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return EaseingFunction.Interpolate(this, tween, currentDuration);
        }
    }
}
