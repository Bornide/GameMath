using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interpolations;

class Quint<TOut> : EasingInterpolation<TOut>
{
    public Quint()
    {
        EasingInFunction = (t) => { return Math.Pow(t, 5); };
        EasingOutFunction = (t) => { return 1 - Math.Pow(1 - t, 5); };
        EasingInOutFunction = (t) => { return t < 0.5 ? 16 * Math.Pow(t, 5) : 1 - Math.Pow(-2 * t + 2, 5) / 2; };
    }
}
