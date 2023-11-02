using GameMath.Tweening.Interpolations;

namespace GameMath.Tweening.Tweens.Simple;

class TweenArray<TIn> : TweenSimple<TIn, decimal[]>
{
    public override decimal[] Update(double currentTime)
    {
        return Interpolation.Interpolate(this, UpdateTime(currentTime));
    }
}
