using GameMath.Core.Exceptions.FluentBuilder;
using System.Security;

namespace GameMath.Tweening
{
    abstract class Tween : IFrom, ITo, IFor, ITween, IBuild
    {
        public double CurrentDuration { get; protected set; }
        public double TotalDuration { get; protected set; }

        public dynamic StartValue { get; protected set; }

        public dynamic EndValue { get; protected set; }

        private bool IsBuilded;

        private bool IsStarted;

        public event ITween.TweenEvent AnimationEnded;

        public ITo From(dynamic startValue)
        {
            StartValue = startValue;
            return this;
        }

        public IFor To(dynamic endValue)
        {
            EndValue = endValue;
            return this;
        }

        public IBuild For(double duration)
        {
            TotalDuration = duration;
            return this;
        }

        public ITween Build()
        {
            IsBuilded = true;
            return this;
        }

        public dynamic Update(double currentTime)
        {
            if (!IsBuilded) throw new UnbuildException();
            if (!IsStarted) return StartValue;

            CurrentDuration = Math.Min(CurrentDuration + currentTime, TotalDuration);
            return Interpolate(CurrentDuration);
        }

        protected void OnAnimationEnded()
        {
            AnimationEnded?.Invoke(this);
        }

        protected abstract dynamic Interpolate(double currentTime);

        public void Start()
        {
            IsStarted = true;
        }

        public void Reverse()
        {
            var bufferValue = StartValue;
            StartValue = EndValue;
            EndValue = bufferValue;
        }

        public void Restart()
        {
            IsStarted = true;
            CurrentDuration = 0;
        }

        public void Stop()
        {
            IsStarted = false;
        }
    }
}
