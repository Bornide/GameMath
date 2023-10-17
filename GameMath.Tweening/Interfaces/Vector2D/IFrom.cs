namespace GameMath.Tweening.Vector2D
{
    public interface IFrom
    {
        ITo From(short x, short y);
        ITo From(int x, int y);
        ITo From(long x, long y);
        ITo From(float x, float y);
        ITo From(double x, double y);
        ITo From(decimal x, decimal y);
    }
}
