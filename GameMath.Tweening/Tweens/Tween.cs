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

        /*protected void OnAnimationEnded()
        {
            AnimationEnded?.Invoke(this);
        }*/
    }
}
