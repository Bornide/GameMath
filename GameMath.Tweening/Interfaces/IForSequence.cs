namespace GameMath.Tweening.Interfaces;

public interface IForSequence<TIn, TOut>
{
    IInterpolation<TIn, TOut> For(double duration);
    IInterpolation<TIn, TOut> For(params double[] durations);
    IInterpolation<TIn, TOut> For(ICollection<double> durations);
}