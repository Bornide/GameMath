using GameMath.Tweening.Interpolations;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    abstract class Ease
    {
        public abstract double[] Interpolate(EasingInterpolation interpolation, Tween<short, double> tween, double currentDuration);
        public abstract double[] Interpolate(EasingInterpolation interpolation, Tween<int, double> tween, double currentDuration);
        public abstract double[] Interpolate(EasingInterpolation interpolation, Tween<long, double> tween, double currentDuration);
        public abstract double[] Interpolate(EasingInterpolation interpolation, Tween<float, double> tween, double currentDuration);
        public abstract double[] Interpolate(EasingInterpolation interpolation, Tween<double, double> tween, double currentDuration);
        public abstract decimal[] Interpolate(EasingInterpolation interpolation, Tween<decimal, decimal> tween, double currentDuration);
    }
}
