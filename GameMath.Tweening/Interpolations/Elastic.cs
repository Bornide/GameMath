using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

class Elastic<TOut> : IntensityEasingInterpolation<TOut>
{
    public Elastic(double intensity)
    {
        SetIntensity(intensity);

        double c4 = (2 * Math.PI) / 3;
        EasingInFunction = (t) => { return 1 - EasingOutFunction(1 - t); };
        EasingOutFunction = (t) => 
        { 
            return t == 0
              ? 0
              : t == 1
              ? 1
              : Math.Pow(2, -10 * t) * Math.Sin((t * 10 * Intensity - 0.75) * c4) + 1;
        };
        EasingInOutFunction = (t) =>
        {
            return t == 0
              ? 0
              : t == 1
              ? 1
              : t < 0.5 ? (1 - EasingOutFunction(1 - 2 * t)) / 2 : (1 + EasingOutFunction(2 * t - 1)) / 2;
        };
    }
}
