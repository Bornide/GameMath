
namespace GameMath.Tweening.Tweens
{
    class Elastic : Interpolation
    {
        public override dynamic Interpolate(Tween tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return EaseingFunction!.Interpolate(this, tween, currentDuration);
        }
    }
}
