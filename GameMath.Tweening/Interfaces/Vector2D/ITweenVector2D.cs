namespace GameMath.Tweening.Vector2D
{
    public interface ITweenVector2D : ITween
    {
        Vectors.Vector2D Update(double currentTime);

        /*delegate void TweenEvent(ITween<T> tween);
        event TweenEvent? AnimationEnded;*/
    }
}
