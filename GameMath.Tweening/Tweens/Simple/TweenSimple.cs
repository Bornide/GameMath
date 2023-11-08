using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Simple;

abstract class TweenSimple<TIn, TOut> : TweenBase<TIn, TOut>,
    IFor<TIn, TOut>,
    IFrom<TIn, TOut>,
    ITo<TIn, TOut>,
    ITo2D<TIn, TOut>,
    ITo3D<TIn, TOut>,
    IToArray<TIn, TOut>
{
    public double CurrentDuration { get; protected set; }
    public double TotalDuration { get; protected set; }
    public TIn[] StartValues { get; protected set; }
    public TIn[] EndValues { get; protected set; }

    public override ITween<TIn, TOut> Start()
    {
        IsStarted = true;
        return this;
    }

    public override ITween<TIn, TOut> Reset()
    {
        InvokeEvent = true;
        CurrentDuration = 0;
        return this;
    }

    public override ITween<TIn, TOut> ChangeSpeed(double ratio)
    {
        if (ratio <= 0) throw new ArgumentException("Ratio must be > 0");
        TotalDuration *= ratio;
        return this;
    }

    public override ITween<TIn, TOut> Reverse()
    {
        TIn[] bufferValue = StartValues;
        StartValues = EndValues;
        EndValues = bufferValue;
        return this;
    }

    public override ITween<TIn, TOut> Pause()
    {
        IsStarted = false;
        return this;
    }

    public override ITween<TIn, TOut> ToggleState()
    {
        IsStarted = !IsStarted;
        return this;
    }

    public ITo<TIn, TOut> From(TIn startValue)
    {
        StartValues = new TIn[] { startValue };
        return this;
    }

    public ITo2D<TIn, TOut> From(TIn x, TIn y)
    {
        StartValues = new TIn[] { x, y };
        return this;
    }

    public ITo2D<TIn, TOut> From(Point2D<TIn> startValue)
    {
        StartValues = new TIn[] { startValue.X, startValue.Y };
        return this;
    }

    public ITo2D<TIn, TOut> From(System.Drawing.Point startValue)
    {
        StartValues = new TIn[] { (TIn)(object)startValue.X, (TIn)(object)startValue.Y };
        return this;
    }

    public ITo2D<TIn, TOut> From(Microsoft.Xna.Framework.Point startValue)
    {
        StartValues = new TIn[] { (TIn)(object)startValue.X, (TIn)(object)startValue.Y };
        return this;
    }

    public ITo2D<TIn, TOut> From(PointF startValue)
    {
        StartValues = new TIn[] { (TIn)(object)startValue.X, (TIn)(object)startValue.Y };
        return this;
    }

    public ITo3D<TIn, TOut> From(TIn x, TIn y, TIn z)
    {
        StartValues = new TIn[] { x, y, z };
        return this;
    }

    public ITo3D<TIn, TOut> From(Point3D<TIn> startValue)
    {
        StartValues = new TIn[] { startValue.X, startValue.Y, startValue.Z };
        return this;
    }

    public IToArray<TIn, TOut> From(ICollection<TIn> startValues)
    {
        return From(startValues.ToArray());
    }

    public IToArray<TIn, TOut> From(params TIn[] startValues)
    {
        StartValues = startValues;
        return this;
    }

    public IFor<TIn, TOut> To(TIn endValue)
    {
        EndValues = new TIn[] { endValue };
        return this;
    }

    public IFor<TIn, TOut> To(TIn x, TIn y)
    {
        EndValues = new TIn[] { x, y };
        return this;
    }

    public IFor<TIn, TOut> To(Point2D<TIn> endValue)
    {
        EndValues = new TIn[] { endValue.X, endValue.Y };
        return this;
    }

    public IFor<TIn, TOut> To(System.Drawing.Point endValue)
    {
        EndValues = new TIn[] { (TIn)(object)endValue.X, (TIn)(object)endValue.Y };
        return this;
    }

    public IFor<TIn, TOut> To(Microsoft.Xna.Framework.Point endValue)
    {
        EndValues = new TIn[] { (TIn)(object)endValue.X, (TIn)(object)endValue.Y };
        return this;
    }

    public IFor<TIn, TOut> To(PointF endValue)
    {
        EndValues = new TIn[] { (TIn)(object)endValue.X, (TIn)(object)endValue.Y };
        return this;
    }

    public IFor<TIn, TOut> To(TIn x, TIn y, TIn z)
    {
        EndValues = new TIn[] { x, y, z };
        return this;
    }

    public IFor<TIn, TOut> To(Point3D<TIn> endValue)
    {
        EndValues = new TIn[] { endValue.X, endValue.Y, endValue.Z };
        return this;
    }

    public IFor<TIn, TOut> To(ICollection<TIn> endValues)
    {
        return To(endValues.ToArray());
    }

    public IFor<TIn, TOut> To(params TIn[] endValues)
    {
        if (endValues.Length != StartValues.Length)
            throw new ArgumentException("The number of end values doesn't match the number of start values");
        EndValues = endValues;
        return this;
    }

    public IInterpolation<TIn, TOut> For(double duration)
    {
        if (duration <= 0) throw new ArgumentException("Duration must be > 0");
        TotalDuration = duration;
        return this;
    }

    public override ITween<TIn, TOut> Build()
    {
        CurrentDuration = 0;
        IsBuilded = true;
        return this;
    }

    protected double UpdateTime(double currentTime, bool triggerAnimationEnded = true)
    {
        if (!IsStarted) return CurrentDuration;
        CurrentDuration += currentTime;
        if (CurrentDuration <= TotalDuration) return CurrentDuration;

        //Animation ended
        IsStarted = false;
        CurrentDuration = TotalDuration;

        if (triggerAnimationEnded) OnAnimationEnded();
        return CurrentDuration;
    }
}
