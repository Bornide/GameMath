namespace GameMath.Tweening.Interfaces;

public interface IEase<TIn, TOut>
{
    ILoop<TIn, TOut> EaseIn();
    ILoop<TIn, TOut> EaseOut();
    ILoop<TIn, TOut> EaseInOut();
}