namespace GameMath.Tweening.Short.SingleValue;

public interface IEase
{
    IBuild EaseIn();
    IBuild EaseOut();
    IBuild EaseInOut();
}