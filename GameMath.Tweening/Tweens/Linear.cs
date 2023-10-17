
namespace GameMath.Tweening
{
    class Linear : Tween
    {
        protected override dynamic Interpolate(double currentTime)
        {
            if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return (EndValue - StartValue) * (currentTime / TotalDuration) + StartValue;
        }
    }
}
