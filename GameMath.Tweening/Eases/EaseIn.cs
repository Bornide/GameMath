using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    class EaseIn : Ease
    {
        public override dynamic Interpolate(Quadratic interpolation, Tween tween, double currentDuration)
        {
            return tween.EndValue * (currentDuration /= tween.TotalDuration) * currentDuration + tween.StartValue;
        }

        public override dynamic Interpolate(Cubic interpolation, Tween tween, double currentDuration)
        {
            throw new NotImplementedException();
        }

        public override dynamic Interpolate(Elastic interpolation, Tween tween, double currentDuration)
        {
            throw new NotImplementedException();
        }
    }
}
