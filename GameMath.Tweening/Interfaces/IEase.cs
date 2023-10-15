namespace GameMath.Tweening
{
    public interface IEase
    {
        IFrom EaseIn();
        IFrom EaseOut();
        IFrom EaseInOut();
    }
}