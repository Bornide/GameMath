namespace GameMath.Tweening.Interpolations;

class Quint<TIn, TOut> : EasingInterpolation<TIn, TOut>
{
    public Quint()
    {
        EasingInFunction = (t) => { return Math.Pow(t, 5); };
        EasingOutFunction = (t) => { return 1 - Math.Pow(1 - t, 5); };
        EasingInOutFunction = (t) => { return t < 0.5 ? 16 * Math.Pow(t, 5) : 1 - Math.Pow(-2 * t + 2, 5) / 2; };
    }
}
