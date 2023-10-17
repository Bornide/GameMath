namespace GameMath.Tweening.Point
{
    public interface IFrom
    {
        ITo From(short startValue);
        ITo From(int startValue);
        ITo From(long startValue);
        ITo From(float startValue);
        ITo From(double startValue);
        ITo From(decimal startValue);
    }
}
