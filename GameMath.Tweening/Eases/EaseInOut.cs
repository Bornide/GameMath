
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    internal class EaseInOut : Ease
    {
        public override dynamic Interpolate(Quadratic interpolation, Tween tween, double currentDuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Interpolate(Cubic interpolation, Tween tween, double currentDuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Interpolate(Elastic interpolation, Tween tween, double currentDuration)
        {
            double t = currentDuration / tween.TotalDuration;
            double c1 = 1.70158;
            double c2 = c1 * 1.525;
            var elastic = t < 0.5
              ? (Math.Pow(2 * t, 2) * ((c2 + 1) * 2 * t - c2)) / 2
              : (Math.Pow(2 * t - 2, 2) * ((c2 + 1) * (t * 2 - 2) + c2) + 2) / 2;

            return tween.StartValue + (tween.EndValue - tween.StartValue) * elastic;
        }
    }
}
