using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class Interpolation<TOut>
{
    protected decimal[] StartValuesBuffer { get; set; }
    protected decimal[] EndValuesBuffer { get; set; }
    protected decimal[] ResultBuffer { get; set; }

    public abstract decimal[] Interpolate(Tween<short, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<int, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<long, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<float, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<double, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<decimal, TOut> tween, double currentDuration);
}
