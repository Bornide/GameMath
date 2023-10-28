using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class Interpolation
{
    public abstract double[] Interpolate(Tween<short, double> tween, double currentDuration);
    public abstract double[] Interpolate(Tween<int, double> tween, double currentDuration);
    public abstract double[] Interpolate(Tween<long, double> tween, double currentDuration);
    public abstract double[] Interpolate(Tween<float, double> tween, double currentDuration);
    public abstract double[] Interpolate(Tween<double, double> tween, double currentDuration);
    public abstract decimal[] Interpolate(Tween<decimal, decimal> tween, double currentDuration);
}
