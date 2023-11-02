using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Tweens.Simple;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

abstract class TweenSequence<TIn, TOut> : TweenBase<TIn, TOut>,
    ITweenSequence<TIn, TOut>,
    ITweenSequenceAdd<TIn, TOut>,
    ITweenSequenceFor<TIn, TOut>
{
    protected double[] TotalDurations;
    protected int CurrentStepIndex;
    protected List<TIn[]> Values { get; private set; } = new List<TIn[]>();

    public override void Reverse()
    {
        List<TIn[]> newValues = new List<TIn[]>();
        for (int i = Values.Count - 1; i >= 0; i++) newValues.Add(Values[i]);
        Values = newValues;
    }

    public override void Reset()
    {
        CurrentStepIndex = 0;
        base.Reset();
    }

    public ITweenSequenceAdd<TIn, TOut> Add(TIn value)
    {
        Values.Add(new TIn[]{ value });
        return this;
    }

    public ITweenSequenceAdd<TIn, TOut> Add(Point2D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y });
        return this;
    }

    public ITweenSequenceAdd<TIn, TOut> Add(System.Drawing.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ITweenSequenceAdd<TIn, TOut> Add(Microsoft.Xna.Framework.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ITweenSequenceAdd<TIn, TOut> Add(PointF value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ITweenSequenceAdd<TIn, TOut> Add(Point3D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y, value.Z });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceAdd<TIn, TOut>.Add(TIn value)
    {
        Values.Add(new TIn[] { value });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceAdd<TIn, TOut>.Add(Point2D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceAdd<TIn, TOut>.Add(System.Drawing.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceAdd<TIn, TOut>.Add(Microsoft.Xna.Framework.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceAdd<TIn, TOut>.Add(PointF value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceAdd<TIn, TOut>.Add(Point3D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y, value.Z });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceFor<TIn, TOut>.Add(TIn value)
    {
        Values.Add(new TIn[] { value });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceFor<TIn, TOut>.Add(Point2D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceFor<TIn, TOut>.Add(System.Drawing.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceFor<TIn, TOut>.Add(Microsoft.Xna.Framework.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceFor<TIn, TOut>.Add(PointF value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    ITweenSequenceFor<TIn, TOut> ITweenSequenceFor<TIn, TOut>.Add(Point3D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y, value.Z });
        return this;
    }

    public IFor<TIn, TOut> AddRange(ICollection<TIn> values)
    {
        Values.Add(values.ToArray());
        return this;
    }

    public IFor<TIn, TOut> AddRange(ICollection<Point2D<TIn>> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IFor<TIn, TOut> AddRange(ICollection<System.Drawing.Point> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IFor<TIn, TOut> AddRange(ICollection<Microsoft.Xna.Framework.Point> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IFor<TIn, TOut> AddRange(ICollection<PointF> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IFor<TIn, TOut> AddRange(ICollection<Point3D<TIn>> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public override ITween<TIn, TOut> Build()
    {
        //TODO : Adapter les durations à l'espacement entre les points
        TotalDurations = new double[Values.Count];
        for (int i = 0; i < Values.Count; i++) TotalDurations[i] = TotalDuration / Values.Count;
        return base.Build();
    }
}
