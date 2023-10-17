namespace GameMath.Tweening.Point
{
    public interface ITweenPoint : ITween
    {
        dynamic Update(double currentTime);

        /*delegate void TweenEvent(ITween<T> tween);
        event TweenEvent? AnimationEnded;*/
    }
}
