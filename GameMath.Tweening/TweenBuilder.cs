
using GameMath.Tweening;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening
{
    public static class TweenBuilder
    {
        public static SingleValue.ITo From(short startValue) => new FromPoint().From(startValue);
        public static SingleValue.ITo From(int startValue) => new FromPoint().From(startValue);
        public static SingleValue.ITo From(long startValue) => new FromPoint().From(startValue);
        public static SingleValue.ITo From(float startValue) => new FromPoint().From(startValue);
        public static SingleValue.ITo From(double startValue) => new FromPoint().From(startValue);
        public static SingleValue.ITo From(decimal startValue) => new FromPoint().From(startValue);

        public static Vector2D.ITo From(short x, short y) => new FromVector2D().From(x, y);
        public static Vector2D.ITo From(int x, int y) => new FromVector2D().From(x, y);
        public static Vector2D.ITo From(long x, long y) => new FromVector2D().From(x, y);
        public static Vector2D.ITo From(float x, float y) => new FromVector2D().From(x, y);
        public static Vector2D.ITo From(double x, double y) => new FromVector2D().From(x, y);
        public static Vector2D.ITo From(decimal x, decimal y) => new FromVector2D().From(x, y);
    }
}
