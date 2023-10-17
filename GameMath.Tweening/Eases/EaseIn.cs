

namespace GameMath.Tweening
{
    class EaseIn : Ease
    {
        public override dynamic Interpolate(Quadratic tween, double currentDuration)
        {
            return tween.EndValue * (currentDuration /= tween.TotalDuration) * currentDuration + tween.StartValue;
        }

        public override dynamic Interpolate(Cubic tween, double currentDuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Interpolate(Elastic tween, double currentDuration)
        {
            double t = currentDuration / tween.TotalDuration;
            double c1 = 1.70158;
            double c2 = c1 * 1.525;
            var elastic = t < 0.5
              ? (Math.Pow(2 * t, 2) * ((c2 + 1) * 2 * t - c2)) / 2
              : (Math.Pow(2 * t - 2, 2) * ((c2 + 1) * (t * 2 - 2) + c2) + 2) / 2;

            return tween.StartValue + tween.EndValue * elastic;
        }
    }
}
