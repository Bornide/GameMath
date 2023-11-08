using GameMath.Tweening.Tweens.Simple;

namespace GameMath.Tweening.Interpolations;

abstract class Interpolation<TIn, TOut>
{
    protected decimal[]? ResultBuffer;

    public abstract decimal[] Interpolate(TweenSimple<TIn, TOut> tween, double currentDuration);
}
