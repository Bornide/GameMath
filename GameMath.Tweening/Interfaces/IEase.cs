namespace GameMath.Tweening.Interfaces;

public interface IEase<TIn, TOut>
{
    IBuild<TIn, TOut> EaseIn();
    IBuild<TIn, TOut> EaseOut();
    IBuild<TIn, TOut> EaseInOut();
}