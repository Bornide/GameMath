using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Tweens.Sequence;

namespace GameMath.Tweening;

public static partial class TweenBuilder
{
    public static ISequenceTo<short, decimal> Add(short value) => new Tween<short>().Add(value);
    public static ISequenceTo<int, decimal> Add(int value) => new Tween<int>().Add(value);
    public static ISequenceTo<long, decimal> Add(long value) => new Tween<long>().Add(value);
    public static ISequenceTo<float, decimal> Add(float value) => new Tween<float>().Add(value);
    public static ISequenceTo<double, decimal> Add(double value) => new Tween<double>().Add(value);
    public static ISequenceTo<decimal, decimal> Add(decimal value) => new Tween<decimal>().Add(value);

    public static ISequenceTo2D<short, Point2D<decimal>> Add(Point2D<short> value) => new Tween2D<short>().Add(value);
    public static ISequenceTo2D<int, Point2D<decimal>> Add(Point2D<int> value) => new Tween2D<int>().Add(value);
    public static ISequenceTo2D<int, Point2D<decimal>> Add(System.Drawing.Point value) => new Tween2D<int>().Add(value);
    public static ISequenceTo2D<int, Point2D<decimal>> Add(Microsoft.Xna.Framework.Point value) => new Tween2D<int>().Add(value);
    public static ISequenceTo2D<long, Point2D<decimal>> Add(Point2D<long> value) => new Tween2D<long>().Add(value);
    public static ISequenceTo2D<float, Point2D<decimal>> Add(Point2D<float> value) => new Tween2D<float>().Add(value);
    public static ISequenceTo2D<float, Point2D<decimal>> Add(System.Drawing.PointF value) => new Tween2D<float>().Add(value);
    public static ISequenceTo2D<double, Point2D<decimal>> Add(Point2D<double> value) => new Tween2D<double>().Add(value);
    public static ISequenceTo2D<decimal, Point2D<decimal>> Add(Point2D<decimal> value) => new Tween2D<decimal>().Add(value);

    public static ISequenceTo3D<short, Point3D<decimal>> Add(Point3D<short> value) => new Tween3D<short>().Add(value);
    public static ISequenceTo3D<int, Point3D<decimal>> Add(Point3D<int> value) => new Tween3D<int>().Add(value);
    public static ISequenceTo3D<long, Point3D<decimal>> Add(Point3D<long> value) => new Tween3D<long>().Add(value);
    public static ISequenceTo3D<float, Point3D<decimal>> Add(Point3D<float> value) => new Tween3D<float>().Add(value);
    public static ISequenceTo3D<double, Point3D<decimal>> Add(Point3D<double> value) => new Tween3D<double>().Add(value);
    public static ISequenceTo3D<decimal, Point3D<decimal>> Add(Point3D<decimal> value) => new Tween3D<decimal>().Add(value);

    public static ISequenceFor<short, decimal[]> AddRange(ICollection<short> values) => new TweenArray<short>().AddRange(values);
    public static ISequenceFor<int, decimal[]> AddRange(ICollection<int> values) => new TweenArray<int>().AddRange(values);
    public static ISequenceFor<long, decimal[]> AddRange(ICollection<long> values) => new TweenArray<long>().AddRange(values);
    public static ISequenceFor<float, decimal[]> AddRange(ICollection<float> values) => new TweenArray<float>().AddRange(values);
    public static ISequenceFor<double, decimal[]> AddRange(ICollection<double> values) => new TweenArray<double>().AddRange(values);
    public static ISequenceFor<decimal, decimal[]> AddRange(ICollection<decimal> values) => new TweenArray<decimal>().AddRange(values);

    public static ISequenceFor<short, Point2D<decimal>> AddRange(ICollection<Point2D<short>> values) => new Tween2D<short>().AddRange(values);
    public static ISequenceFor<int, Point2D<decimal>> AddRange(ICollection<Point2D<int>> values) => new Tween2D<int>().AddRange(values);
    public static ISequenceFor<int, Point2D<decimal>> AddRange(ICollection<System.Drawing.Point> values) => new Tween2D<int>().AddRange(values);
    public static ISequenceFor<int, Point2D<decimal>> AddRange(ICollection<Microsoft.Xna.Framework.Point> values) => new Tween2D<int>().AddRange(values);
    public static ISequenceFor<long, Point2D<decimal>> AddRange(ICollection<Point2D<long>> values) => new Tween2D<long>().AddRange(values);
    public static ISequenceFor<float, Point2D<decimal>> AddRange(ICollection<Point2D<float>> values) => new Tween2D<float>().AddRange(values);
    public static ISequenceFor<float, Point2D<decimal>> AddRange(ICollection<System.Drawing.PointF> values) => new Tween2D<float>().AddRange(values);
    public static ISequenceFor<double, Point2D<decimal>> AddRange(ICollection<Point2D<double>> values) => new Tween2D<double>().AddRange(values);
    public static ISequenceFor<decimal, Point2D<decimal>> AddRange(ICollection<Point2D<decimal>> values) => new Tween2D<decimal>().AddRange(values);

    public static ISequenceFor<short, Point3D<decimal>> AddRange(ICollection<Point3D<short>> values) => new Tween3D<short>().AddRange(values);
    public static ISequenceFor<int, Point3D<decimal>> AddRange(ICollection<Point3D<int>> values) => new Tween3D<int>().AddRange(values);
    public static ISequenceFor<long, Point3D<decimal>> AddRange(ICollection<Point3D<long>> values) => new Tween3D<long>().AddRange(values);
    public static ISequenceFor<float, Point3D<decimal>> AddRange(ICollection<Point3D<float>> values) => new Tween3D<float>().AddRange(values);
    public static ISequenceFor<double, Point3D<decimal>> AddRange(ICollection<Point3D<double>> values) => new Tween3D<double>().AddRange(values);
    public static ISequenceFor<decimal, Point3D<decimal>> AddRange(ICollection<Point3D<decimal>> values) => new Tween3D<decimal>().AddRange(values);
}
