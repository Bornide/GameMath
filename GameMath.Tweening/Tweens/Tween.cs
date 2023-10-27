using GameMath.Core;
using GameMath.Tweening.Interfaces;

namespace GameMath.Tweening.Tweens
{
    abstract class Tween<T> : ITween<T>, IFor<T>, IInterpolation<T>, IEase<T>, IBuild<T>
    {
        public double CurrentDuration { get; protected set; }
        public double TotalDuration { get; protected set; }
        public T StartValues { get; protected set; }
        public T EndValues { get; protected set; }
        
        //public event ITween<T>.TweenEvent? AnimationEnded;

        protected bool IsBuilded = false;
        protected bool IsStarted = false;
        protected Interpolation<T> Interpolation;

        public void Start()
        {
            IsStarted = true;
        }

        public T Update(double currentTime)
        {
            return Interpolation.Interpolate(this, CurrentDuration);
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

        public IInterpolation<T> For(double duration)
        {
            TotalDuration = duration;
            return this;
        }

        public IBuild<T> Linear()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Sine()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Quad()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Cubic()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Quart()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Quint()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Expo()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Circ()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Back()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Elastic()
        {
            throw new NotImplementedException();
        }

        public IEase<T> Bounce()
        {
            throw new NotImplementedException();
        }
    }
}
