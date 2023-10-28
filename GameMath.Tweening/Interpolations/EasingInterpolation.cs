using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class EasingInterpolation : Interpolation
{
    public Ease EasingFunction { get; set; }

    public override double[] Interpolate(Tween<short, double> tween, double currentDuration)
    {
        return EasingFunction.Interpolate(this, tween, currentDuration);
    }

    public override double[] Interpolate(Tween<int, double> tween, double currentDuration)
    {
        return EasingFunction.Interpolate(this, tween, currentDuration);
    }

    public override double[] Interpolate(Tween<long, double> tween, double currentDuration)
    {
        return EasingFunction.Interpolate(this, tween, currentDuration);
    }

    public override double[] Interpolate(Tween<float, double> tween, double currentDuration)
    {
        return EasingFunction.Interpolate(this, tween, currentDuration);
    }

    public override double[] Interpolate(Tween<double, double> tween, double currentDuration)
    {
        return EasingFunction.Interpolate(this, tween, currentDuration);
    }

    public override decimal[] Interpolate(Tween<decimal, decimal> tween, double currentDuration)
    {
        return EasingFunction.Interpolate(this, tween, currentDuration);
    }

    public abstract double[] Interpolate(EaseIn easeIn, Tween<short, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseIn easeIn, Tween<int, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseIn easeIn, Tween<long, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseIn easeIn, Tween<float, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseIn easeIn, Tween<double, double> tween, double currentDuration);
    public abstract decimal[] Interpolate(EaseIn easeIn, Tween<decimal, decimal> tween, double currentDuration);

    public abstract double[] Interpolate(EaseOut easeOut, Tween<short, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseOut easeOut, Tween<int, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseOut easeOut, Tween<long, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseOut easeOut, Tween<float, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseOut easeOut, Tween<double, double> tween, double currentDuration);
    public abstract decimal[] Interpolate(EaseOut easeOut, Tween<decimal, decimal> tween, double currentDuration);

    public abstract double[] Interpolate(EaseInOut easeInOut, Tween<short, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseInOut easeInOut, Tween<int, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseInOut easeInOut, Tween<long, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseInOut easeInOut, Tween<float, double> tween, double currentDuration);
    public abstract double[] Interpolate(EaseInOut easeInOut, Tween<double, double> tween, double currentDuration);
    public abstract decimal[] Interpolate(EaseInOut easeInOut, Tween<decimal, decimal> tween, double currentDuration);
}
