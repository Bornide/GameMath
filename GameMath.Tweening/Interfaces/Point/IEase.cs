namespace GameMath.Tweening.Point
{
    public interface IEase
    {
        IBuild EaseIn();
        IBuild EaseOut();
        IBuild EaseInOut();
    }
}