using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;

namespace GameMath.Tweening
{
    public static class TweenBuilder
    {
        public static ITo<short, decimal> From(short startValue) => new Tweens.TweenBase<short>().From(startValue);
        public static ITo<int, decimal> From(int startValue) => new Tweens.TweenBase<int>().From(startValue);
        public static ITo<long, decimal> From(long startValue) => new Tweens.TweenBase<long>().From(startValue);
        public static ITo<float, decimal> From(float startValue) => new Tweens.TweenBase<float>().From(startValue);
        public static ITo<double, decimal> From(double startValue) => new Tweens.TweenBase<double>().From(startValue);
        public static ITo<decimal, decimal> From(decimal startValue) => new Tweens.TweenBase<decimal>().From(startValue);

        public static ITo2D<short, Point2D<decimal>> From(short x, short y) => new Tweens.Tween2D<short>().From(x, y);
        public static ITo2D<int, Point2D<decimal>> From(int x, int y) => new Tweens.Tween2D<int>().From(x, y);
        public static ITo2D<long, Point2D<decimal>> From(long x, long y) => new Tweens.Tween2D<long>().From(x, y);
        public static ITo2D<float, Point2D<decimal>> From(float x, float y) => new Tweens.Tween2D<float>().From(x, y);
        public static ITo2D<double, Point2D<decimal>> From(double x, double y) => new Tweens.Tween2D<double>().From(x, y);
        public static ITo2D<decimal, Point2D<decimal>> From(decimal x, decimal y) => new Tweens.Tween2D<decimal>().From(x, y);

        public static ITo2D<short, Point2D<decimal>> From(Point2D<short> startValue) => new Tweens.Tween2D<short>().From(startValue);
        public static ITo2D<int, Point2D<decimal>> From(Point2D<int> startValue) => new Tweens.Tween2D<int>().From(startValue);
        public static ITo2D<int, Point2D<decimal>> From(System.Drawing.Point startValue) => new Tweens.Tween2D<int>().From(startValue);
        public static ITo2D<int, Point2D<decimal>> From(Microsoft.Xna.Framework.Point startValue) => new Tweens.Tween2D<int>().From(startValue);
        public static ITo2D<long, Point2D<decimal>> From(Point2D<long> startValue) => new Tweens.Tween2D<long>().From(startValue);
        public static ITo2D<float, Point2D<decimal>> From(Point2D<float> startValue) => new Tweens.Tween2D<float>().From(startValue);
        public static ITo2D<float, Point2D<decimal>> From(System.Drawing.PointF startValue) => new Tweens.Tween2D<float>().From(startValue);
        public static ITo2D<double, Point2D<decimal>> From(Point2D<double> startValue) => new Tweens.Tween2D<double>().From(startValue);
        public static ITo2D<decimal, Point2D<decimal>> From(Point2D<decimal> startValue) => new Tweens.Tween2D<decimal>().From(startValue);

        public static ITo3D<short, Point3D<decimal>> From(short x, short y, short z) => new Tweens.Tween3D<short>().From(x, y, z);
        public static ITo3D<int, Point3D<decimal>> From(int x, int y, int z) => new Tweens.Tween3D<int>().From(x, y, z);
        public static ITo3D<long, Point3D<decimal>> From(long x, long y, long z) => new Tweens.Tween3D<long>().From(x, y, z);
        public static ITo3D<float, Point3D<decimal>> From(float x, float y, float z) => new Tweens.Tween3D<float>().From(x, y, z);
        public static ITo3D<double, Point3D<decimal>> From(double x, double y, double z) => new Tweens.Tween3D<double>().From(x, y, z);
        public static ITo3D<decimal, Point3D<decimal>> From(decimal x, decimal y, decimal z) => new Tweens.Tween3D<decimal>().From(x, y, z);

        public static ITo3D<short, Point3D<decimal>> From(Point3D<short> startValue) => new Tweens.Tween3D<short>().From(startValue);
        public static ITo3D<int, Point3D<decimal>> From(Point3D<int> startValue) => new Tweens.Tween3D<int>().From(startValue);
        public static ITo3D<long, Point3D<decimal>> From(Point3D<long> startValue) => new Tweens.Tween3D<long>().From(startValue);
        public static ITo3D<float, Point3D<decimal>> From(Point3D<float> startValue) => new Tweens.Tween3D<float>().From(startValue);
        public static ITo3D<double, Point3D<decimal>> From(Point3D<double> startValue) => new Tweens.Tween3D<double>().From(startValue);
        public static ITo3D<decimal, Point3D<decimal>> From(Point3D<decimal> startValue) => new Tweens.Tween3D<decimal>().From(startValue);

        public static IToArray<short, decimal[]> From(params short[] startValues) => new Tweens.TweenArray<short>().From(startValues);
        public static IToArray<int, decimal[]> From(params int[] startValues) => new Tweens.TweenArray<int>().From(startValues);
        public static IToArray<long, decimal[]> From(params long[] startValues) => new Tweens.TweenArray<long>().From(startValues);
        public static IToArray<float, decimal[]> From(params float[] startValues) => new Tweens.TweenArray<float>().From(startValues);
        public static IToArray<double, decimal[]> From(params double[] startValues) => new Tweens.TweenArray<double>().From(startValues);
        public static IToArray<decimal, decimal[]> From(params decimal[] startValues) => new Tweens.TweenArray<decimal>().From(startValues);
    }
}
