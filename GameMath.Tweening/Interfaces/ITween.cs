namespace GameMath.Tweening
{
    public interface ITween
    {
        dynamic Update(double currentTime);
        void Start();
        void Reverse();
        void Restart();
        void Stop();

        delegate void TweenEvent(ITween tween);
        event TweenEvent AnimationEnded;
    }
}
