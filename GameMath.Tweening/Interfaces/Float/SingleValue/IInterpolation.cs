namespace GameMath.Tweening.Float.SingleValue;

public interface IInterpolation
{
    IBuild Linear();
    IEase Sine();
    IEase Quad();
    IEase Cubic();
    IEase Quart();
    IEase Quint();
    IEase Expo();
    IEase Circ();
    IEase Back();
    IEase Elastic();
    IEase Bounce();
}
