using GameMath.Tweening.Interpolations;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    class EaseIn : Ease
    {
        /*public override dynamic Interpolate(Quadratic interpolation, Tween tween, double currentDuration)
        {
            return tween.EndValue * (currentDuration /= tween.TotalDuration) * currentDuration + tween.StartValue;
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
