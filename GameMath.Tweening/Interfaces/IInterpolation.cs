namespace GameMath.Tweening.Interfaces;

public interface IInterpolation<T>
{
    IBuild<T> Linear();
    IEase<T> Sine();
    IEase<T> Quad();
    IEase<T> Cubic();
    IEase<T> Quart();
    IEase<T> Quint();
    IEase<T> Expo();
    IEase<T> Circ();
    IEase<T> Back();
    IEase<T> Elastic();
    IEase<T> Bounce();
}
