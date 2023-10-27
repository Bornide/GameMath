namespace GameMath.Tweening.Interfaces;

public interface ITo<T>
{
    IFor<T> To(T endValue);
}
