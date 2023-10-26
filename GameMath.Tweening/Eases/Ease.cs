using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    abstract class Ease
    {
        public abstract dynamic Interpolate(Quadratic interpolation, Tween tween, double currentDuration);
        public abstract dynamic Interpolate(Cubic interpolation, Tween tween, double currentDuration);
        public abstract dynamic Interpolate(Elastic interpolation, Tween tween, double currentDuration);
        public abstract Vectors.Short.Vector2D Interpolate2D(Quadratic interpolation, Tween tween, double currentDuration);
        public abstract Vectors.Short.Vector2D Interpolate2D(Cubic interpolation, Tween tween, double currentDuration);
        public abstract Vectors.Short.Vector2D Interpolate2D(Elastic interpolation, Tween tween, double currentDuration);
    }
}
