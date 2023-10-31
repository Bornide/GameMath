using GameMath.Tweening.Interpolations;

namespace GameMath.Tweening.Tweens;

class TweenArray<TIn> : Tween<TIn, decimal[]>
{
    public override decimal[] Update(double currentTime)
    {
        return Interpolation.Interpolate(this, UpdateTime(currentTime));
    }
}
