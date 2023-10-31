namespace GameMath.Tweening.Tweens;

class TweenBase<TIn> : Tween<TIn, decimal>
{
    public override decimal Update(double currentTime)
    {
        return Interpolation.Interpolate(this, UpdateTime(currentTime))[0];
    }
}
