using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Tweens.Sequence;

namespace GameMath.Tweening;

public static partial class TweenBuilder
{
    public static ITweenSequenceAdd<short, decimal> Add(short value) => new Tween<short>().Add(value);
    public static ITweenSequenceAdd<int, decimal> Add(int value) => new Tween<int>().Add(value);
    public static ITweenSequenceAdd<long, decimal> Add(long value) => new Tween<long>().Add(value);
    public static ITweenSequenceAdd<float, decimal> Add(float value) => new Tween<float>().Add(value);
    public static ITweenSequenceAdd<double, decimal> Add(double value) => new Tween<double>().Add(value);
    public static ITweenSequenceAdd<decimal, decimal> Add(decimal value) => new Tween<decimal>().Add(value);

    public static ITweenSequenceAdd<short, Point2D<decimal>> Add(Point2D<short> value) => new Tween2D<short>().Add(value);
    public static ITweenSequenceAdd<int, Point2D<decimal>> Add(Point2D<int> value) => new Tween2D<int>().Add(value);
    public static ITweenSequenceAdd<int, Point2D<decimal>> Add(System.Drawing.Point value) => new Tween2D<int>().Add(value);
    public static ITweenSequenceAdd<int, Point2D<decimal>> Add(Microsoft.Xna.Framework.Point value) => new Tween2D<int>().Add(value);
    public static ITweenSequenceAdd<long, Point2D<decimal>> Add(Point2D<long> value) => new Tween2D<long>().Add(value);
    public static ITweenSequenceAdd<float, Point2D<decimal>> Add(Point2D<float> value) => new Tween2D<float>().Add(value);
    public static ITweenSequenceAdd<float, Point2D<decimal>> Add(System.Drawing.PointF value) => new Tween2D<float>().Add(value);
    public static ITweenSequenceAdd<double, Point2D<decimal>> Add(Point2D<double> value) => new Tween2D<double>().Add(value);
    public static ITweenSequenceAdd<decimal, Point2D<decimal>> Add(Point2D<decimal> value) => new Tween2D<decimal>().Add(value);

    public static ITweenSequenceAdd<short, Point3D<decimal>> Add(Point3D<short> value) => new Tween3D<short>().Add(value);
    public static ITweenSequenceAdd<int, Point3D<decimal>> Add(Point3D<int> value) => new Tween3D<int>().Add(value);
    public static ITweenSequenceAdd<long, Point3D<decimal>> Add(Point3D<long> value) => new Tween3D<long>().Add(value);
    public static ITweenSequenceAdd<float, Point3D<decimal>> Add(Point3D<float> value) => new Tween3D<float>().Add(value);
    public static ITweenSequenceAdd<double, Point3D<decimal>> Add(Point3D<double> value) => new Tween3D<double>().Add(value);
    public static ITweenSequenceAdd<decimal, Point3D<decimal>> Add(Point3D<decimal> value) => new Tween3D<decimal>().Add(value);

    public static IForSequence<short, decimal[]> AddRange(ICollection<short> values) => new TweenArray<short>().AddRange(values);
    public static IForSequence<int, decimal[]> AddRange(ICollection<int> values) => new TweenArray<int>().AddRange(values);
    public static IForSequence<long, decimal[]> AddRange(ICollection<long> values) => new TweenArray<long>().AddRange(values);
    public static IForSequence<float, decimal[]> AddRange(ICollection<float> values) => new TweenArray<float>().AddRange(values);
    public static IForSequence<double, decimal[]> AddRange(ICollection<double> values) => new TweenArray<double>().AddRange(values);
    public static IForSequence<decimal, decimal[]> AddRange(ICollection<decimal> values) => new TweenArray<decimal>().AddRange(values);

    public static IForSequence<short, Point2D<decimal>> AddRange(ICollection<Point2D<short>> values) => new Tween2D<short>().AddRange(values);
    public static IForSequence<int, Point2D<decimal>> AddRange(ICollection<Point2D<int>> values) => new Tween2D<int>().AddRange(values);
    public static IForSequence<int, Point2D<decimal>> AddRange(ICollection<System.Drawing.Point> values) => new Tween2D<int>().AddRange(values);
    public static IForSequence<int, Point2D<decimal>> AddRange(ICollection<Microsoft.Xna.Framework.Point> values) => new Tween2D<int>().AddRange(values);
    public static IForSequence<long, Point2D<decimal>> AddRange(ICollection<Point2D<long>> values) => new Tween2D<long>().AddRange(values);
    public static IForSequence<float, Point2D<decimal>> AddRange(ICollection<Point2D<float>> values) => new Tween2D<float>().AddRange(values);
    public static IForSequence<float, Point2D<decimal>> AddRange(ICollection<System.Drawing.PointF> values) => new Tween2D<float>().AddRange(values);
    public static IForSequence<double, Point2D<decimal>> AddRange(ICollection<Point2D<double>> values) => new Tween2D<double>().AddRange(values);
    public static IForSequence<decimal, Point2D<decimal>> AddRange(ICollection<Point2D<decimal>> values) => new Tween2D<decimal>().AddRange(values);

    public static IForSequence<short, Point3D<decimal>> AddRange(ICollection<Point3D<short>> values) => new Tween3D<short>().AddRange(values);
    public static IForSequence<int, Point3D<decimal>> AddRange(ICollection<Point3D<int>> values) => new Tween3D<int>().AddRange(values);
    public static IForSequence<long, Point3D<decimal>> AddRange(ICollection<Point3D<long>> values) => new Tween3D<long>().AddRange(values);
    public static IForSequence<float, Point3D<decimal>> AddRange(ICollection<Point3D<float>> values) => new Tween3D<float>().AddRange(values);
    public static IForSequence<double, Point3D<decimal>> AddRange(ICollection<Point3D<double>> values) => new Tween3D<double>().AddRange(values);
    public static IForSequence<decimal, Point3D<decimal>> AddRange(ICollection<Point3D<decimal>> values) => new Tween3D<decimal>().AddRange(values);
}
