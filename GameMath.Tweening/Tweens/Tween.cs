using GameMath.Core;
using GameMath.Tweening.Eases;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Interpolations;
using System.Linq;

namespace GameMath.Tweening.Tweens
{
    abstract class Tween<TIn, TOut> : ITween<TIn, TOut>, 
        IFrom<TIn, TOut>,
        ITo<TIn, TOut>,
        ITo2D<TIn, TOut>,
        ITo3D<TIn, TOut>,
        IToCollection<TIn, TOut>,
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
        protected Interpolation<TOut> Interpolation;

        public void Start()
        {
            IsStarted = true;
        }

        public void Restart()
        {
            IsStarted = true;
            InvokeEvent = true;
            CurrentDuration = 0;
        }

        public void Reverse()
        {
            TIn[] bufferValue = StartValues;
            StartValues = EndValues;
            EndValues = bufferValue;
        }

        public void Stop()
        {
            IsStarted = false;
        }

        public void Toggle()
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

        public ITo3D<TIn, TOut> From(TIn x, TIn y, TIn z)
        {
            StartValues = new TIn[] { x, y, z };
            return this;
        }

        public IToCollection<TIn, TOut> From(params TIn[] startValues)
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

        public IFor<TIn, TOut> To(TIn x, TIn y, TIn z)
        {
            EndValues = new TIn[] { x, y, z };
            return this;
        }

        public IFor<TIn, TOut> To(params TIn[] endValues)
        {
            if (endValues.Length != StartValues.Length)
                throw new ArgumentException("Invalid endValues count.");
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
            Interpolation = new Linear<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Sine()
        {
            Interpolation = new Sine<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Quadratic()
        {
            Interpolation = new Quadratic<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Cubic()
        {
            Interpolation = new Cubic<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Quart()
        {
            Interpolation = new Quart<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Quint()
        {
            Interpolation = new Quint<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Expo()
        {
            Interpolation = new Expo<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Circular()
        {
            Interpolation = new Circular<TOut>();
            return this;
        }

        public IEase<TIn, TOut> Back(double intensity = 1)
        {
            Interpolation = new Back<TOut>(intensity);
            return this;
        }

        public IEase<TIn, TOut> Elastic(double intensity = 1)
        {
            Interpolation = new Elastic<TOut>(intensity);
            return this;
        }

        public IEase<TIn, TOut> Bounce(double intensity = 1)
        {
            Interpolation = new Bounce<TOut>(intensity);
            return this;
        }

        public ILoop<TIn, TOut> EaseIn()
        {
            var easingInterpolation = Interpolation as EasingInterpolation<TOut>;
            easingInterpolation!.EasingFunction = new EaseIn<TOut>();
            return this;
        }

        public ILoop<TIn, TOut> EaseOut()
        {
            var easingInterpolation = Interpolation as EasingInterpolation<TOut>;
            easingInterpolation!.EasingFunction = new EaseOut<TOut>();
            return this;
        }
        public ILoop<TIn, TOut> EaseInOut()
        {
            var easingInterpolation = Interpolation as EasingInterpolation<TOut>;
            easingInterpolation!.EasingFunction = new EaseInOut<TOut>();
            return this;
        }

        public IBuild<TIn, TOut> Loop(int waitBeforeRestart)
        {
            if (waitBeforeRestart <= 0) { AnimationEnded += (tween) => { tween.Restart(); }; return this; }
            AnimationEnded += (tween) =>
            {
                new Thread(() =>
                {
                    Thread.Sleep(waitBeforeRestart);
                    tween.Restart();
                }).Start();
            };
            return this;
        }

        public IBuild<TIn, TOut> LoopReverse(int waitBeforeRestart)
        {
            if(waitBeforeRestart <= 0) { AnimationEnded += (tween) => { tween.Reverse(); tween.Restart(); }; return this; }
            AnimationEnded += (tween) => 
            { 
                new Thread(() => 
                { 
                    Thread.Sleep(waitBeforeRestart);
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
}
