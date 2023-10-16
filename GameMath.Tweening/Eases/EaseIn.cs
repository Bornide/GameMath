

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
            double c = tween.TotalDuration / 2f;
            double p = 1;
            return -c * Math.Pow(2, 10 * (currentDuration / tween.TotalDuration - 1)) * 
                Math.Sin((currentDuration/tween.TotalDuration - 1 - p / 4) * (2 * Math.PI) / p) + tween.StartValue;
        }
    }
}
