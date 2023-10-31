using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class Interpolation<TIn, TOut>
{
    protected decimal[]? ResultBuffer;

    public abstract decimal[] Interpolate(Tween<TIn, TOut> tween, double currentDuration);
}
