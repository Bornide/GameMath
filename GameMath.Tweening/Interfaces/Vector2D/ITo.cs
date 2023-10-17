namespace GameMath.Tweening.Vector2D
{
    public interface ITo
    {
        IFor To(short x, short y);
        IFor To(int x, int y);
        IFor To(long x, long y);
        IFor To(float x, float y);
        IFor To(double x, double y);
        IFor To(decimal x, decimal y);
    }
}
