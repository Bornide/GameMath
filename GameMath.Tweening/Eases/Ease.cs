using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    abstract class Ease<T>
    {
        public abstract T Interpolate(Quadratic<T> interpolation, Tween<T> tween, double currentDuration);
        public abstract T Interpolate(Cubic<T> interpolation, Tween<T> tween, double currentDuration);
        public abstract T Interpolate(Elastic<T> interpolation, Tween<T> tween, double currentDuration);
    }
}
