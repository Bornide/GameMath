using GameMath.Tweening.Interpolations;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Eases;

abstract class Ease<TOut>
{
    public abstract decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<short, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<int, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<long, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<float, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<double, TOut> tween, double currentDuration);
    public abstract decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<decimal, TOut> tween, double currentDuration);
}
