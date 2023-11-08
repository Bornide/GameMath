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
    ISequenceFor<TIn, TOut>,
    ISequenceFrom<TIn, TOut>,
    ISequenceTo<TIn, TOut>,
    ISequenceTo2D<TIn, TOut>,
    ISequenceTo3D<TIn, TOut>
{
    protected int CurrentStepIndex;
    protected double[] TotalDurations { get; private set; }

    private List<ITween<TIn, TOut>> _tweens { get; set; } = new List<ITween<TIn, TOut>>();
    private List<TIn[]> _values { get; set; } = new List<TIn[]>();
    private ITween<TIn, TOut> CurrentTween => _tweens[CurrentStepIndex];
    private bool OnLastStep => CurrentStepIndex == _tweens.Count - 1;

    public override ITween<TIn, TOut> Start()
    {
        IsStarted = true;
        CurrentTween.Start();
        return this;
    }

    public override ITween<TIn, TOut> Reset()
    {
        InvokeEvent = true;
        CurrentStepIndex = 0;
        _tweens.ForEach(t => t.Reset());
        return this;
    }

    public override ITween<TIn, TOut> ChangeSpeed(double ratio)
    {
        if (ratio <= 0) throw new ArgumentException("Ratio must be > 0");
        for(int i=0; i<TotalDurations.Length; i++) TotalDurations[i] *= ratio;
        return this;
    }

    public override ITween<TIn, TOut> Reverse()
    {
        var newTweens = new List<ITween<TIn, TOut>>();
        for (int i = _tweens.Count - 1; i >= 0; i--) newTweens.Add(_tweens[i].Reverse());
        _tweens = newTweens;
        return this;
    }

    public override ITween<TIn, TOut> Pause()
    {
        IsStarted = false;
        CurrentTween.Pause();
        return this;
    }

    public override ITween<TIn, TOut> ToggleState()
    {
        IsStarted = !IsStarted;
        CurrentTween.ToggleState();
        return this;
    }

    public ISequenceTo<TIn, TOut> Add(TIn value)
    {
        _values.Add(new TIn[]{ value });
        return this;
    }

    public ISequenceTo2D<TIn, TOut> Add(Point2D<TIn> value)
    {
        _values.Add(new TIn[] { value.X, value.Y });
        return this;
    }

    public ISequenceTo2D<TIn, TOut> Add(System.Drawing.Point value)
    {
        _values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ISequenceTo2D<TIn, TOut> Add(Microsoft.Xna.Framework.Point value)
    {
        _values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ISequenceTo2D<TIn, TOut> Add(PointF value)
    {
        _values.Add(new TIn[] { (TIn)(object)value.X, (TIn)(object)value.Y });
        return this;
    }

    public ISequenceTo3D<TIn, TOut> Add(Point3D<TIn> value)
    {
        _values.Add(new TIn[] { value.X, value.Y, value.Z });
        return this;
    }

    public ISequenceFor<TIn, TOut> AddRange(ICollection<TIn> values)
    {
        _values.Add(values.ToArray());
        return this;
    }

    public ISequenceFor<TIn, TOut> AddRange(ICollection<Point2D<TIn>> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public ISequenceFor<TIn, TOut> AddRange(ICollection<System.Drawing.Point> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public ISequenceFor<TIn, TOut> AddRange(ICollection<Microsoft.Xna.Framework.Point> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public ISequenceFor<TIn, TOut> AddRange(ICollection<PointF> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public ISequenceFor<TIn, TOut> AddRange(ICollection<Point3D<TIn>> values)
    {
        foreach (var value in values) Add(value);
        return this;
    }

    public IInterpolation<TIn, TOut> For(double duration)
    {
        if (duration <= 0) throw new ArgumentException("Duration must be > 0");
        TotalDurations = new double[_values.Count];
        for (int i = 0; i < _values.Count; i++) TotalDurations[i] = duration;
        return this;
    }

    public IInterpolation<TIn, TOut> For(params double[] durations)
    {
        if (durations.Any(d => d <= 0)) throw new ArgumentException("Durations must be > 0");
        else if (_values.Count - 1 != durations.Length)
            throw new ArgumentException("The number of durations doesn't match the number of sequences (3 values = 2 sequences)");
        TotalDurations = durations.ToArray();
        return this;
    }

    public IInterpolation<TIn, TOut> For(ICollection<double> durations)
    {
        return For(durations.ToArray());
    }

    public override ITween<TIn, TOut> Build()
    {
        if (_values.Count < 2)
            throw new ArgumentException("Not enough values for the tween sequence");
        
        for (int i = 0; i < _values.Count - 1; i++)
        {
            var tween = this.CreateInstance();
            tween.From(_values[i]);
            tween.To(_values[i+1]);
            tween.For(TotalDurations[i]);
            tween.Interpolation = this.Interpolation;
            tween.AnimationEnded += (t) =>
            {
                if (OnLastStep) this.OnAnimationEnded();
                else
                {
                    CurrentStepIndex++;
                    CurrentTween.Start();
                }
            };
            _tweens.Add(tween);
        }
        IsBuilded = true;

        return this;
    }

    public override TOut Update(double currentTime)
    {
        return CurrentTween.Update(currentTime);
    }

    protected abstract TweenSimple<TIn, TOut> CreateInstance();
}
