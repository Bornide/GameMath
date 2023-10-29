using GameMath.Core.Extensions;
using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

class Back<TOut> : IntensityEasingInterpolation<TOut>
{
    public Back(double intensity)
    {
        SetIntensity(intensity);

        double c1 = 1.70158 * Intensity;
        double c2 = c1 * 1.525;
        double c3 = c1 + 1;
        EasingInFunction = (t) => { return c3 * t * t * t - c1 * t * t; };
        EasingOutFunction = (t) => { return 1 + c3 * Math.Pow(t - 1, 3) + c1 * Math.Pow(t - 1, 2); };
        EasingInOutFunction = (t) => 
        { 
            return t > 0.5 ?
            (Math.Pow(2 * t - 2, 2) * ((c2 + 1) * (t * 2 - 2) + c2) + 2) / 2 :
            (Math.Pow(2 * t, 2) * ((c2 + 1) * 2 * t - c2)) / 2;
        };
    }
}
