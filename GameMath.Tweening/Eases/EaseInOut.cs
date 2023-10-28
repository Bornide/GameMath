using GameMath.Tweening.Interpolations;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    internal class EaseInOut : Ease
    {
        /*private dynamic Interpolate(Elastic interpolation, Tween tween, double currentDuration)
        {
            double t = currentDuration / tween.TotalDuration;
            double c1 = 1.70158;
            double c2 = c1 * 1.525;
            var elastic = t < 0.5
              ? (Math.Pow(2 * t, 2) * ((c2 + 1) * 2 * t - c2)) / 2
              : (Math.Pow(2 * t - 2, 2) * ((c2 + 1) * (t * 2 - 2) + c2) + 2) / 2;

            return tween.StartValue + (tween.EndValue - tween.StartValue) * elastic;
        }*/

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
