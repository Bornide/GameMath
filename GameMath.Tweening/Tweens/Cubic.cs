namespace GameMath.Tweening.Tweens
{
    internal class Cubic : Interpolation
    {
        public override dynamic Interpolate(Tween tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return EaseingFunction!.Interpolate(this, tween, currentDuration);
        }
    }
}
