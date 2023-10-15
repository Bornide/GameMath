

namespace GameMath.Tweening
{
    abstract class Ease
    {
        public abstract dynamic Interpolate(Quadratic tween, double currentDuration);
        public abstract dynamic Interpolate(Cubic tween, double currentDuration);
    }
}
