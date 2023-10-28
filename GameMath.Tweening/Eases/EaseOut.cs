using GameMath.Tweening.Interpolations;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    internal class EaseOut : Ease
    {
        public override double[] Interpolate(EasingInterpolation interpolation, Tween<short, double> tween, double currentDuration)
        {
            return interpolation.Interpolate(this, tween, currentDuration);
        }

        public override double[] Interpolate(EasingInterpolation interpolation, Tween<int, double> tween, double currentDuration)
        {
            return interpolation.Interpolate(this, tween, currentDuration);
        }

        public override double[] Interpolate(EasingInterpolation interpolation, Tween<long, double> tween, double currentDuration)
        {
            return interpolation.Interpolate(this, tween, currentDuration);
        }

        public override double[] Interpolate(EasingInterpolation interpolation, Tween<float, double> tween, double currentDuration)
        {
            return interpolation.Interpolate(this, tween, currentDuration);
        }

        public override double[] Interpolate(EasingInterpolation interpolation, Tween<double, double> tween, double currentDuration)
        {
            return interpolation.Interpolate(this, tween, currentDuration);
        }

        public override decimal[] Interpolate(EasingInterpolation interpolation, Tween<decimal, decimal> tween, double currentDuration)
        {
            return interpolation.Interpolate(this, tween, currentDuration);
        }
    }
}
