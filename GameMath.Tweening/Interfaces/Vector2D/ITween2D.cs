namespace GameMath.Tweening.Vector2D
{
    public interface ITween2D : ITween
    {
        Vector2D Update(double currentTime);

        /*delegate void TweenEvent(ITween<T> tween);
        event TweenEvent? AnimationEnded;*/
    }
}
