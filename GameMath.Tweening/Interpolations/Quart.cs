namespace GameMath.Tweening.Interpolations;

class Quart<TIn, TOut> : EasingInterpolation<TIn, TOut>
{
    public Quart()
    {
        EasingInFunction = (t) => { return Math.Pow(t, 4); };
        EasingOutFunction = (t) => { return 1 - Math.Pow(1 - t, 4); };
        EasingInOutFunction = (t) => { return t < 0.5 ? 8 * Math.Pow(t, 4) : 1 - Math.Pow(-2 * t + 2, 4) / 2; };
    }
}
