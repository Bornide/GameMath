namespace GameMath.Tweening.Interfaces;

public interface IFor<TIn, TOut>
{
    IInterpolation<TIn, TOut> For(double duration);
}