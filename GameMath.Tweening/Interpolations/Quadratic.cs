using GameMath.Core.Extensions;
using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

class Quadratic<TOut> : EasingInterpolation<TOut>
{
    public Quadratic()
    {
        EasingInFunction = (t) => { return Math.Pow(t, 2); };
        EasingOutFunction = (t) => { return 1 - Math.Pow(1 - t, 2); };
        EasingInOutFunction = (t) => { return t < 0.5 ? 2 * Math.Pow(t, 2) : 1 - Math.Pow(-2 * t + 2, 2) / 2; };
    }
}
