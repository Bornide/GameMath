namespace GameMath.Tweening.SingleValue
{
    public interface IInterpolation
    {
        IBuild Linear();
        IEase Cubic();
        IEase Elastic();
        IEase Quadratic();
    }
}
