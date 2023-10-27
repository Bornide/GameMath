namespace GameMath.Tweening.Interfaces;

public interface IEase<T>
{
    IBuild<T> EaseIn();
    IBuild<T> EaseOut();
    IBuild<T> EaseInOut();
}