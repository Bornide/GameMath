namespace GameMath.Tweening.Long.SingleValue;

public interface IEase
{
    IBuild EaseIn();
    IBuild EaseOut();
    IBuild EaseInOut();
}