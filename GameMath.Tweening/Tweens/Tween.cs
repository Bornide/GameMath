using GameMath.Core;
using GameMath.Tweening.Interfaces;
using GameMath.Tweening.Interpolations;

namespace GameMath.Tweening.Tweens
{
    abstract class Tween<TIn, TOut> : ITween<TIn, TOut>, 
        IFrom<TIn, TOut>,
        IFrom2D<TIn, TOut>,
        IFrom3D<TIn, TOut>,
        ITo<TIn, TOut>,
        ITo2D<TIn, TOut>,
        ITo3D<TIn, TOut>,
        IFor<TIn, TOut>,
        IInterpolation<TIn, TOut>,
        IBuild<TIn, TOut>
    {
        public double CurrentDuration { get; protected set; }
        public double TotalDuration { get; protected set; }
        public TIn[] StartValues { get; protected set; }
        public TIn[] EndValues { get; protected set; }
        
        //public event ITween<T>.TweenEvent? AnimationEnded;

        protected bool IsBuilded = false;
        protected bool IsStarted = false;
        //protected Interpolation Interpolation;
        protected Func<TIn[], TOut> Interpolation;

        public void Start()
        {
            IsStarted = true;
        }

        public void Restart()
        {
            IsStarted = true;
            CurrentDuration = 0;
        }

        public void Reverse()
        {
            dynamic bufferValue = StartValues;
            StartValues = EndValues;
            EndValues = bufferValue;
        }

        public void Stop()
        {
            IsStarted = false;
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

        public IInterpolation<TIn, TOut> For(double duration)
        {
            TotalDuration = duration;
            return this;
        }

        public ITween<TIn, TOut> Build()
        {
            return this;
        }

        public abstract IBuild<TIn, TOut> Linear();
        public abstract IEase<TIn, TOut> Sine();
        public abstract IEase<TIn, TOut> Quad();
        public abstract IEase<TIn, TOut> Cubic();
        public abstract IEase<TIn, TOut> Quart();
        public abstract IEase<TIn, TOut> Quint();
        public abstract IEase<TIn, TOut> Expo();
        public abstract IEase<TIn, TOut> Circ();
        public abstract IEase<TIn, TOut> Back();
        public abstract IEase<TIn, TOut> Elastic();
        public abstract IEase<TIn, TOut> Bounce();

        public abstract TOut Update(double currentTime);
    }
}
