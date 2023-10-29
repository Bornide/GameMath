using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

class Elastic<TOut> : IntensityEasingInterpolation<TOut>
{
    public Elastic(double intensity)
    {
        SetIntensity(intensity);

        double c4 = (2 * Math.PI) / 3;
        double c5 = (2 * Math.PI) / 4.5;
        EasingInFunction = (t) => 
        { 
            return t == 0
              ? 0
              : t == 1
              ? 1
              : -Math.Pow(2, 10 * t - 10) * Math.Sin((t * 10 - 10.75) * c4);
        };
        EasingOutFunction = (t) => 
        { 
            return t == 0
              ? 0
              : t == 1
              ? 1
              : Math.Pow(2, -10 * t) * Math.Sin((t * 10 - 0.75) * c4) + 1;
        };
        EasingInOutFunction = (t) =>
        {
            return t == 0
              ? 0
              : t == 1
              ? 1
              : t < 0.5
              ? -(Math.Pow(2, 20 * t - 10) * Math.Sin((20 * t - 11.125) * c5)) / 2
              : (Math.Pow(2, -20 * t + 10) * Math.Sin((20 * t - 11.125) * c5)) / 2 + 1;
        };
    }
}
