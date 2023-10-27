namespace GameMath.Tweening.Float.SingleValue;

public interface IEase
{
    IBuild EaseIn();
    IBuild EaseOut();
    IBuild EaseInOut();
}