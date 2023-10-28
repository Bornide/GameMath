namespace GameMath.Tweening.Interfaces;

public interface IBuild<TIn, TOut>
{
    ITween<TIn, TOut> Build();
}