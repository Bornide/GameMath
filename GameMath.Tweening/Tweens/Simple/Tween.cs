namespace GameMath.Tweening.Tweens.Simple;

class Tween<TIn> : TweenSimple<TIn, decimal>
{
    public override decimal Update(double currentTime)
    {
        return Interpolation.Interpolate(this, UpdateTime(currentTime))[0];
    }
}
