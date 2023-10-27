namespace GameMath.Tweening.Interfaces;

public interface IFor<T>
{
    IInterpolation<T> For(double duration);
}