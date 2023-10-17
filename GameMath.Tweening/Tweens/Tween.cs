using GameMath.Core.Exceptions.FluentBuilder;
using GameMath.Tweening;
using GameMath.Tweening.Point;
using System.Security;

namespace GameMath.Tweening.Tweens
{
    abstract class Tween : ITween
    {
        public double CurrentDuration { get; protected set; }
        public double TotalDuration { get; protected set; }
        public dynamic? StartValue { get; protected set; }
        public dynamic? EndValue { get; protected set; }
        
        //public event ITween<T>.TweenEvent? AnimationEnded;

        protected bool IsBuilded = false;
        protected bool IsStarted = false;
        protected Interpolation? Interpolation;

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
            dynamic bufferValue = StartValue!;
            StartValue = EndValue;
            EndValue = bufferValue;
        }

        public void Stop()
        {
            IsStarted = false;
        }

        /*public T Update<T>(double currentTime)
        {
            if (!_isBuilded) throw new UnbuildException();
            if (!_isStarted) return StartValue!;

            CurrentDuration = Math.Min(CurrentDuration + currentTime, TotalDuration);
            return Interpolate(CurrentDuration, StartValue, EndValue);
        }*/

        /*protected void OnAnimationEnded()
        {
            AnimationEnded?.Invoke(this);
        }*/
    }
}
