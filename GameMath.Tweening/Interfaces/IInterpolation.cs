namespace GameMath.Tweening.Interfaces;

public interface IInterpolation<TIn, TOut>
{
    IBuild<TIn, TOut> Linear();
    IEase<TIn, TOut> Sine();
    IEase<TIn, TOut> Quad();
    IEase<TIn, TOut> Cubic();
    IEase<TIn, TOut> Quart();
    IEase<TIn, TOut> Quint();
    IEase<TIn, TOut> Expo();
    IEase<TIn, TOut> Circ();
    IEase<TIn, TOut> Back();
    IEase<TIn, TOut> Elastic();
    IEase<TIn, TOut> Bounce();
}
