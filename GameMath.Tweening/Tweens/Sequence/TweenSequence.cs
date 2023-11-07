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
    IForSequence<TIn, TOut>,
    ITweenSequence<TIn, TOut>,
    ITweenSequenceFor<TIn, TOut>,
    ITweenSequence2DFor<TIn, TOut>,
    ITweenSequence3DFor<TIn, TOut>
{
    protected int CurrentStepIndex;
    protected double[] TotalDurations { get; private set; }
    protected List<TIn[]> Values { get; private set; } = new List<TIn[]>();
    protected List<ITween<TIn, TOut>> Tweens { get; set; } = new List<ITween<TIn, TOut>>();

    public override void Reverse()
    {
        List<TIn[]> newValues = new List<TIn[]>();
        for (int i = Values.Count - 1; i >= 0; i--) newValues.Add(Values[i]);
        Values = newValues;

        double[] newDurations = new double[TotalDurations.Length];
        for (int i = 0; i < TotalDurations.Length; i++) newDurations[i] = TotalDurations[TotalDurations.Length - i - 1];
        TotalDurations = newDurations;

        TotalDuration = TotalDurations[0];
        StartValues = Values[0];
        EndValues = Values[1];
    }

    public override void Reset()
    {
        CurrentStepIndex = 0;
        base.Reset();
    }

    public ITweenSequenceFor<TIn, TOut> Add(TIn value)
    {
        Values.Add(new TIn[]{ value });
        return this;
    }

    public ITweenSequence2DFor<TIn, TOut> Add(Point2D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y });
        return this;
    }

    public ITweenSequence2DFor<TIn, TOut> Add(System.Drawing.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ITweenSequence2DFor<TIn, TOut> Add(Microsoft.Xna.Framework.Point value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ITweenSequence2DFor<TIn, TOut> Add(PointF value)
    {
        Values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ITweenSequence3DFor<TIn, TOut> Add(Point3D<TIn> value)
    {
        Values.Add(new TIn[] { value.X, value.Y, value.Z });
        return this;
    }

    public IForSequence<TIn, TOut> AddRange(ICollection<TIn> values)
    {
        Values.Add(values.ToArray());
        return this;
    }

    public IForSequence<TIn, TOut> AddRange(ICollection<Point2D<TIn>> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IForSequence<TIn, TOut> AddRange(ICollection<System.Drawing.Point> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IForSequence<TIn, TOut> AddRange(ICollection<Microsoft.Xna.Framework.Point> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IForSequence<TIn, TOut> AddRange(ICollection<PointF> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IForSequence<TIn, TOut> AddRange(ICollection<Point3D<TIn>> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IInterpolation<TIn, TOut> For(double duration)
    {
        TotalDurations = new double[Values.Count];
        for (int i = 0; i < Values.Count; i++) TotalDurations[i] = duration;
        return this;
    }

    public IInterpolation<TIn, TOut> For(params double[] durations)
    {
        if (Values.Count - 1 != durations.Length)
            throw new ArgumentException("The number of durations doesn't match the number of sequences (3 values = 2 sequences)");
        TotalDurations = durations.ToArray();
        return this;
    }

    public IInterpolation<TIn, TOut> For(ICollection<double> durations)
    {
        return For(durations.ToArray());
    }

    public override TOut Update(double currentTime)
    {
        if (!IsStarted && CurrentDuration < TotalDuration) return Interpolate(CurrentDuration);

        if (CurrentDuration >= TotalDuration)
        {
            if (CurrentStepIndex < Values.Count - 2)
            {
                IsStarted = true;
                CurrentDuration = 0;
                CurrentStepIndex++;
            }
            else
            {
                OnAnimationEnded();
                return Interpolate(CurrentDuration);
            }
        }

        TotalDuration = TotalDurations[CurrentStepIndex];
        StartValues = Values[CurrentStepIndex];
        EndValues = Values[CurrentStepIndex + 1];
        var duration = UpdateTime(currentTime, false);
        return Interpolate(duration);
    }

    protected abstract TOut Interpolate(double currentTime);
}
