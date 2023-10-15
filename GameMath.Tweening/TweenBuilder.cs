
namespace GameMath.Tweening
{
    public static class TweenBuilder
    {
        public static IFrom Linear()
        {
            return new Linear();
        }

        public static IEase Quadratic()
        {
            return new Quadratic();
        }

        public static IEase Cubic()
        {
            return new Cubic();
        }
    }
}
