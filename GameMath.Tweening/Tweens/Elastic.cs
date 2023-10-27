namespace GameMath.Tweening.Tweens
{
    class Elastic<T> : EasingInterpolation<T>
    {
        public Elastic(Ease<T> easeingFunction) : base(easeingFunction) { }

        public override T Interpolate(Tween<T> tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return EaseingFunction.Interpolate(this, tween, currentDuration);
        }
    }
}
