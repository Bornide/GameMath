namespace GameMath.Tweening.Interpolations;

class Circular<TIn, TOut> : EasingInterpolation<TIn, TOut>
{
    public Circular()
    {
        EasingInFunction = (t) => { return 1 - Math.Sqrt(1 - Math.Pow(t, 2)); };
        EasingOutFunction = (t) => { return Math.Sqrt(1 - Math.Pow(t - 1, 2)); };
        EasingInOutFunction = (t) => 
        { 
            return t < 0.5
              ? (1 - Math.Sqrt(1 - Math.Pow(2 * t, 2))) / 2
              : (Math.Sqrt(1 - Math.Pow(-2 * t + 2, 2)) + 1) / 2;
        };
    }
}
