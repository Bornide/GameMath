namespace GameMath.Tweening.SingleValue
{
    public interface IEase
    {
        IBuild EaseIn();
        IBuild EaseOut();
        IBuild EaseInOut();
    }
}