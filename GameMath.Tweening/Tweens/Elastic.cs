

namespace GameMath.Tweening
{
    class Elastic : EasingTween
    {
        protected override dynamic Interpolate(double currentTime)
        {
            return Ease.Interpolate(this, currentTime);
        }
    }
}
