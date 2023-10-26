namespace GameMath.Tweening.Tweens
{
    class Elastic : Interpolation
    {
        public override dynamic Interpolate(Tween tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return EaseingFunction!.Interpolate(this, tween, currentDuration);
        }

        public override Vectors.Short.Vector2D Interpolate2D(Tween tween, double currentDuration)
        {
            return EaseingFunction!.Interpolate2D(this, tween, currentDuration);
        }
    }
}
