namespace GameMath.Tweening.Interfaces;

public interface IBuild<T>
{
    ITween<T> Build();
}