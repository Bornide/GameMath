using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class Interpolation<TOut>
{
    protected decimal[] StartValuesBuffer;
    protected decimal[] EndValuesBuffer;
    protected decimal[] ResultBuffer;

    public abstract decimal[] Interpolate(Tween<short, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<int, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<long, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<float, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<double, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<decimal, TOut> tween, double currentDuration);
}
