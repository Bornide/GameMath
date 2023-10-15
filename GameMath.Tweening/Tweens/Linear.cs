
namespace GameMath.Tweening
{
    class Linear : Tween
    {
        protected override dynamic Interpolate(double currentTime)
        {
            return EndValue * (currentTime / TotalDuration) + StartValue;
        }
    }
}
