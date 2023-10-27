namespace GameMath.Tweening.Int.SingleValue;

public interface IEase
{
    IBuild EaseIn();
    IBuild EaseOut();
    IBuild EaseInOut();
}