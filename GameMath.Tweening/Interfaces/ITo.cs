namespace GameMath.Tweening.Interfaces;

public interface ITo<TIn, TOut>
{
    IFor<TIn, TOut> To(TIn endValue);
}
