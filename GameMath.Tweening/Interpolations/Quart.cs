using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interpolations;

class Quart<TOut> : EasingInterpolation<TOut>
{
    public Quart()
    {
        EasingInFunction = (t) => { return Math.Pow(t, 4); };
        EasingOutFunction = (t) => { return 1 - Math.Pow(1 - t, 4); };
        EasingInOutFunction = (t) => { return t < 0.5 ? 8 * Math.Pow(t, 4) : 1 - Math.Pow(-2 * t + 2, 4) / 2; };
    }
}
