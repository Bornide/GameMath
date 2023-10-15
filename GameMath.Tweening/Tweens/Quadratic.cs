
namespace GameMath.Tweening
{
    class Quadratic : EasingTween
    {
        protected override dynamic Interpolate(double currentTime)
        {
            return Ease.Interpolate(this, currentTime);
        }
    }
}
