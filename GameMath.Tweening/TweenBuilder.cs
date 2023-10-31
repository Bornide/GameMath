using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;

namespace GameMath.Tweening
{
    public static class TweenBuilder
    {
        public static ITo<short, decimal> From(short startValue) => new Tweens.Short.Tween().From(startValue);
        public static ITo<int, decimal> From(int startValue) => new Tweens.Int.Tween().From(startValue);
        public static ITo<long, decimal> From(long startValue) => new Tweens.Long.Tween().From(startValue);
        public static ITo<float, decimal> From(float startValue) => new Tweens.Float.Tween().From(startValue);
        public static ITo<double, decimal> From(double startValue) => new Tweens.Double.Tween().From(startValue);
        public static ITo<decimal, decimal> From(decimal startValue) => new Tweens.Decimal.Tween().From(startValue);

        public static ITo2D<short, Point2D<decimal>> From(short x, short y) => new Tweens.Short.Tween2D().From(x, y);
        public static ITo2D<int, Point2D<decimal>> From(int x, int y) => new Tweens.Int.Tween2D().From(x, y);
        public static ITo2D<long, Point2D<decimal>> From(long x, long y) => new Tweens.Long.Tween2D().From(x, y);
        public static ITo2D<float, Point2D<decimal>> From(float x, float y) => new Tweens.Float.Tween2D().From(x, y);
        public static ITo2D<double, Point2D<decimal>> From(double x, double y) => new Tweens.Double.Tween2D().From(x, y);
        public static ITo2D<decimal, Point2D<decimal>> From(decimal x, decimal y) => new Tweens.Decimal.Tween2D().From(x, y);

        public static ITo2D<short, Point2D<decimal>> From(Point2D<short> startValue) => new Tweens.Short.Tween2D().From(startValue);
        public static ITo2D<int, Point2D<decimal>> From(Point2D<int> startValue) => new Tweens.Int.Tween2D().From(startValue);
        public static ITo2D<int, Point2D<decimal>> From(System.Drawing.Point startValue) => new Tweens.Int.Tween2D().From(startValue);
        public static ITo2D<int, Point2D<decimal>> From(Microsoft.Xna.Framework.Point startValue) => new Tweens.Int.Tween2D().From(startValue);
        public static ITo2D<long, Point2D<decimal>> From(Point2D<long> startValue) => new Tweens.Long.Tween2D().From(startValue);
        public static ITo2D<float, Point2D<decimal>> From(Point2D<float> startValue) => new Tweens.Float.Tween2D().From(startValue);
        public static ITo2D<float, Point2D<decimal>> From(System.Drawing.PointF startValue) => new Tweens.Float.Tween2D().From(startValue);
        public static ITo2D<double, Point2D<decimal>> From(Point2D<double> startValue) => new Tweens.Double.Tween2D().From(startValue);
        public static ITo2D<decimal, Point2D<decimal>> From(Point2D<decimal> startValue) => new Tweens.Decimal.Tween2D().From(startValue);

        public static ITo3D<short, Point3D<decimal>> From(short x, short y, short z) => new Tweens.Short.Tween3D().From(x, y, z);
        public static ITo3D<int, Point3D<decimal>> From(int x, int y, int z) => new Tweens.Int.Tween3D().From(x, y, z);
        public static ITo3D<long, Point3D<decimal>> From(long x, long y, long z) => new Tweens.Long.Tween3D().From(x, y, z);
        public static ITo3D<float, Point3D<decimal>> From(float x, float y, float z) => new Tweens.Float.Tween3D().From(x, y, z);
        public static ITo3D<double, Point3D<decimal>> From(double x, double y, double z) => new Tweens.Double.Tween3D().From(x, y, z);
        public static ITo3D<decimal, Point3D<decimal>> From(decimal x, decimal y, decimal z) => new Tweens.Decimal.Tween3D().From(x, y, z);

        public static ITo3D<short, Point3D<decimal>> From(Point3D<short> startValue) => new Tweens.Short.Tween3D().From(startValue);
        public static ITo3D<int, Point3D<decimal>> From(Point3D<int> startValue) => new Tweens.Int.Tween3D().From(startValue);
        public static ITo3D<long, Point3D<decimal>> From(Point3D<long> startValue) => new Tweens.Long.Tween3D().From(startValue);
        public static ITo3D<float, Point3D<decimal>> From(Point3D<float> startValue) => new Tweens.Float.Tween3D().From(startValue);
        public static ITo3D<double, Point3D<decimal>> From(Point3D<double> startValue) => new Tweens.Double.Tween3D().From(startValue);
        public static ITo3D<decimal, Point3D<decimal>> From(Point3D<decimal> startValue) => new Tweens.Decimal.Tween3D().From(startValue);

        public static IToCollection<short, decimal[]> From(params short[] startValues) => new Tweens.Short.TweenCollection().From(startValues);
        public static IToCollection<int, decimal[]> From(params int[] startValues) => new Tweens.Int.TweenCollection().From(startValues);
        public static IToCollection<long, decimal[]> From(params long[] startValues) => new Tweens.Long.TweenCollection().From(startValues);
        public static IToCollection<float, decimal[]> From(params float[] startValues) => new Tweens.Float.TweenCollection().From(startValues);
        public static IToCollection<double, decimal[]> From(params double[] startValues) => new Tweens.Double.TweenCollection().From(startValues);
        public static IToCollection<decimal, decimal[]> Fromparams(decimal[] startValues) => new Tweens.Decimal.TweenCollection().From(startValues);
    }
}
