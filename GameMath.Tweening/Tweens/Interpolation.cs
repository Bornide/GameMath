namespace GameMath.Tweening.Tweens
{
    abstract class Interpolation<T>
    {
        public abstract T Interpolate(Tween<T> tween, double currentDuration);
    }
}
