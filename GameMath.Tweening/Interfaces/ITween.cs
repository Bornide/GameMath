namespace GameMath.Tweening
{
    public interface ITween
    {
        dynamic Update(double currentTime);

        void Start();

        void Stop();
    }
}
