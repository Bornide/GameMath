using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interpolations;

class Expo<TOut> : EasingInterpolation<TOut>
{
    public Expo()
    {
        EasingInFunction = (t) => { return t == 0 ? 0 : Math.Pow(2, 10 * t - 10); };
        EasingOutFunction = (t) => { return t == 1 ? 1 : 1 - Math.Pow(2, -10 * t); };
        EasingInOutFunction = (t) =>
        {
            return t == 0
              ? 0
              : t == 1
              ? 1
              : t < 0.5 ? Math.Pow(2, 20 * t - 10) / 2
              : (2 - Math.Pow(2, -20 * t + 10)) / 2;
        };
    }
}
