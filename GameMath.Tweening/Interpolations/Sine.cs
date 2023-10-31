namespace GameMath.Tweening.Interpolations;

class Sine<TIn, TOut> : EasingInterpolation<TIn, TOut>
{
    public Sine()
    {
        EasingInFunction = (t) => { return 1 - Math.Cos((t * Math.PI) / 2); };
        EasingOutFunction = (t) => { return Math.Sin((t * Math.PI) / 2); };
        EasingInOutFunction = (t) => { return -(Math.Cos(Math.PI * t) - 1) / 2; };
    }
}
