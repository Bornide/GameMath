namespace GameMath.Tweening.Interpolations;

class Bounce<TIn, TOut> : IntensityEasingInterpolation<TIn, TOut>
{
    public Bounce(double intensity)
    {
        SetIntensity(intensity);

        double n1 = 7.5625;
        double d1 = 2.75;
        EasingInFunction = (t) => { return 1 - EasingOutFunction(1 - t); };
        EasingOutFunction = (t) =>
        {
            if (t < 1 / d1)
                return n1 * t * t;
            else if (t < 2 / d1)
                return n1 * (t -= 1.5 / d1) * t + 0.75;
            else if (t < 2.5 / d1)
                return n1 * (t -= 2.25 / d1) * t + 0.9375;
            else
                return n1 * (t -= 2.625 / d1) * t + 0.984375;
        };
        EasingInOutFunction = (t) =>
        {
            return t < 0.5
              ? (1 - EasingOutFunction(1 - 2 * t)) / 2
              : (1 + EasingOutFunction(2 * t - 1)) / 2;
        };
    }
}
