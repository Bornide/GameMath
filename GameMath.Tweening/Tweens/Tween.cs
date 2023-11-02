using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Interpolations;
using System.Drawing;

namespace GameMath.Tweening.Tweens;

abstract class Tween<TIn, TOut> : ITween<TIn, TOut>, 
    IFrom<TIn, TOut>,
    ITo<TIn, TOut>,
    ITo2D<TIn, TOut>,
    ITo3D<TIn, TOut>,
    IToArray<TIn, TOut>,
    IFor<TIn, TOut>,
    IInterpolation<TIn, TOut>,
    IEase<TIn, TOut>, 
    ILoop<TIn, TOut>,
    IBuild<TIn, TOut>
{
    public event ITween<TIn, TOut>.TweenEvent AnimationEnded;
    public double CurrentDuration { get; protected set; } = 0;
    public double TotalDuration { get; protected set; }
    public TIn[] StartValues { get; protected set; }
    public TIn[] EndValues { get; protected set; }
    
    //public event ITween<T>.TweenEvent? AnimationEnded;

    protected bool IsBuilded = false;
    protected bool IsStarted = false;
    protected bool InvokeEvent = true;
    protected Interpolation<TIn, TOut> Interpolation;

    public void Start()
    {
        IsStarted = true;
    }

    public void Reset()
    {
        InvokeEvent = true;
        CurrentDuration = 0;
    }

    public void Restart()
    {
        Reset();
        Start();
    }

    public void Reverse()
    {
        TIn[] bufferValue = StartValues;
        StartValues = EndValues;
        EndValues = bufferValue;
    }

    public void Pause()
    {
        IsStarted = false;
    }

    public void Stop()
    {
        Reset();
        IsStarted = false;
    }

    public void ToggleState()
    {
        IsStarted = !IsStarted;
    }

    public ITo<TIn, TOut> From(TIn startValue)
    {
        StartValues = new TIn[]{ startValue };
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

    IFor<TIn, TOut> ITo2D<TIn, TOut>.To(System.Drawing.Point endValue)
    {
        EndValues = new TIn[] { (TIn)(object)endValue.X, (TIn)(object)endValue.Y };
        return this;
    }

    IFor<TIn, TOut> ITo2D<TIn, TOut>.To(Microsoft.Xna.Framework.Point endValue)
    {
        EndValues = new TIn[] { (TIn)(object)endValue.X, (TIn)(object)endValue.Y };
        return this;
    }

    IFor<TIn, TOut> ITo2D<TIn, TOut>.To(PointF endValue)
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

    public IFor<TIn, TOut> To(params TIn[] endValues)
    {
        if (endValues.Length != StartValues.Length)
            throw new ArgumentException("The number of end values doesn't match the number of start values");
        EndValues = endValues;
        return this;
    }

    public IInterpolation<TIn, TOut> For(double duration)
    {
        TotalDuration = duration;
        return this;
    }

    public ILoop<TIn, TOut> Linear()
    {
        Interpolation = new Linear<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Sine()
    {
        Interpolation = new Sine<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Quadratic()
    {
        Interpolation = new Quadratic<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Cubic()
    {
        Interpolation = new Cubic<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Quart()
    {
        Interpolation = new Quart<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Quint()
    {
        Interpolation = new Quint<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Expo()
    {
        Interpolation = new Expo<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Circular()
    {
        Interpolation = new Circular<TIn, TOut>();
        return this;
    }

    public IEase<TIn, TOut> Back(double intensity = 1)
    {
        Interpolation = new Back<TIn, TOut>(intensity);
        return this;
    }

    public IEase<TIn, TOut> Elastic(double intensity = 1)
    {
        Interpolation = new Elastic<TIn, TOut>(intensity);
        return this;
    }

    public IEase<TIn, TOut> Bounce(double intensity = 1)
    {
        Interpolation = new Bounce<TIn, TOut>(intensity);
        return this;
    }

    public ILoop<TIn, TOut> EaseIn()
    {
        var easingInterpolation = Interpolation as EasingInterpolation<TIn, TOut>;
        easingInterpolation!.EasingType = Core.Enums.Ease.EaseIn;
        return this;
    }

    public ILoop<TIn, TOut> EaseOut()
    {
        var easingInterpolation = Interpolation as EasingInterpolation<TIn, TOut>;
        easingInterpolation!.EasingType = Core.Enums.Ease.EaseOut;
        return this;
    }
    public ILoop<TIn, TOut> EaseInOut()
    {
        var easingInterpolation = Interpolation as EasingInterpolation<TIn, TOut>;
        easingInterpolation!.EasingType = Core.Enums.Ease.EaseInOut;
        return this;
    }

    public IBuild<TIn, TOut> Loop(uint delay)
    {
        if (delay == 0) { AnimationEnded += (tween) => { tween.Restart(); }; return this; }
        AnimationEnded += (tween) =>
        {
            new Thread(() =>
            {
                Thread.Sleep((int)delay);
                tween.Restart();
            }).Start();
        };
        return this;
    }

    public IBuild<TIn, TOut> LoopAlternate(uint delay)
    {
        if(delay == 0) { AnimationEnded += (tween) => { tween.Reverse(); tween.Restart(); }; return this; }
        AnimationEnded += (tween) => 
        { 
            new Thread(() => 
            { 
                Thread.Sleep((int)delay);
                tween.Reverse();
                tween.Restart(); 
            }).Start();
        };
        return this;
    }

    public ITween<TIn, TOut> Build()
    {
        return this;
    }

    public abstract TOut Update(double currentTime);

    protected double UpdateTime(double currentTime)
    {
        if (!IsStarted) return CurrentDuration;
        CurrentDuration += currentTime;
        if (CurrentDuration <= TotalDuration) return CurrentDuration;

        //Animation ended
        IsStarted = false;
        CurrentDuration = TotalDuration;

        if (InvokeEvent)
        {
            InvokeEvent = false;
            AnimationEnded?.Invoke(this);
        }
        return CurrentDuration;
    }
}