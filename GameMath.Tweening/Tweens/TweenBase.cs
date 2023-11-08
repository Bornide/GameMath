using GameMath.Core.Geometry;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Interpolations;
using System.Drawing;

namespace GameMath.Tweening.Tweens;

abstract class TweenBase<TIn, TOut> : ITween<TIn, TOut>,
    IInterpolation<TIn, TOut>,
    IEase<TIn, TOut>, 
    ILoop<TIn, TOut>,
    IBuild<TIn, TOut>
{
    public event ITween<TIn, TOut>.TweenEvent? AnimationEnded;
    public Interpolation<TIn, TOut> Interpolation;

    protected bool IsBuilded = false;
    protected bool IsStarted = false;
    protected bool InvokeEvent = true;

    public ITween<TIn, TOut> Restart()
    {
        Reset();
        Start();
        return this;
    }

    public ITween<TIn, TOut> Stop()
    {
        Reset();
        IsStarted = false;
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

    public abstract ITween<TIn, TOut> Build();
    public abstract ITween<TIn, TOut> Start();
    public abstract ITween<TIn, TOut> Reset();
    public abstract ITween<TIn, TOut> ChangeSpeed(double ratio);
    public abstract ITween<TIn, TOut> Reverse();
    public abstract ITween<TIn, TOut> Pause();
    public abstract ITween<TIn, TOut> ToggleState();
    public abstract TOut Update(double currentTime);

    protected void OnAnimationEnded()
    {
        if (InvokeEvent)
        {
            InvokeEvent = false;
            AnimationEnded?.Invoke(this);
        }
    }
}