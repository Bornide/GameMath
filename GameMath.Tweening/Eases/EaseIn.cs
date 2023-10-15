

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

    }
}
