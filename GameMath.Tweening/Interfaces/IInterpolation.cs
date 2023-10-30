namespace GameMath.Tweening.Interfaces;

public interface IInterpolation<TIn, TOut>
{
    ILoop<TIn, TOut> Linear();
    IEase<TIn, TOut> Sine();
    IEase<TIn, TOut> Quadratic();
    IEase<TIn, TOut> Cubic();
    IEase<TIn, TOut> Quart();
    IEase<TIn, TOut> Quint();
    IEase<TIn, TOut> Expo();
    IEase<TIn, TOut> Circular();
    IEase<TIn, TOut> Back(double intensity = 1);
    IEase<TIn, TOut> Elastic(double intensity = 1);
    IEase<TIn, TOut> Bounce(double intensity = 1);
}
