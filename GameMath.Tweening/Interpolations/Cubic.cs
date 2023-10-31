namespace GameMath.Tweening.Interpolations;

class Cubic<TIn, TOut> : EasingInterpolation<TIn, TOut>
{
    public Cubic()
    {
        EasingInFunction = (t) => { return Math.Pow(t, 3); };
        EasingOutFunction = (t) => { return 1 - Math.Pow(1 - t, 3); };
        EasingInOutFunction = (t) => { return t < 0.5 ? 4 * Math.Pow(t, 3) : 1 - Math.Pow(-2 * t + 2, 3) / 2; };
    }
}
