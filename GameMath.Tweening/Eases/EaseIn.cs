using GameMath.Tweening.Interpolations;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Eases;

class EaseIn<TOut> : Ease<TOut>
{
    /*public override dynamic Interpolate(Quadratic interpolation, Tween tween, double currentDuration)
    {
        return tween.EndValue * (currentDuration /= tween.TotalDuration) * currentDuration + tween.StartValue;
    }*/
    public override decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<short, TOut> tween, double currentDuration)
    {
        return interpolation.Interpolate(this, tween, currentDuration);
    }

    public override decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<int, TOut> tween, double currentDuration)
    {
        return interpolation.Interpolate(this, tween, currentDuration);
    }

    public override decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<long, TOut> tween, double currentDuration)
    {
        return interpolation.Interpolate(this, tween, currentDuration);
    }

    public override decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<float, TOut> tween, double currentDuration)
    {
        return interpolation.Interpolate(this, tween, currentDuration);
    }

    public override decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<double, TOut> tween, double currentDuration)
    {
        return interpolation.Interpolate(this, tween, currentDuration);
    }

    public override decimal[] Interpolate(EasingInterpolation<TOut> interpolation, Tween<decimal, TOut> tween, double currentDuration)
    {
        return interpolation.Interpolate(this, tween, currentDuration);
    }
}
