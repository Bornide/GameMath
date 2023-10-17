namespace GameMath.Tweening.Point
{
    public interface ITo
    {
        IFor To(short endValue);
        IFor To(int endValue);
        IFor To(long endValue);
        IFor To(float endValue);
        IFor To(double endValue);
        IFor To(decimal endValue);
    }
}
