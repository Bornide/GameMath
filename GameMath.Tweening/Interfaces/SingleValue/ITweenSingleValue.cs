namespace GameMath.Tweening.SingleValue
{
    public interface ITweenSingleValue : GameMath.Tweening.ITween
    {
        dynamic Update(double currentTime);

        /*delegate void TweenEvent(ITween<T> tween);
        event TweenEvent? AnimationEnded;*/
    }
}
