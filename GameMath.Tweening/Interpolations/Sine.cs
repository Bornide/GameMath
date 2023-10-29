using GameMath.Core.Extensions;
using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interpolations;

class Sine<TOut> : EasingInterpolation<TOut>
{
    public Sine()
    {
        EasingInFunction = (t) => { return 1 - Math.Cos((t * Math.PI) / 2); };
        EasingOutFunction = (t) => { return Math.Sin((t * Math.PI) / 2); };
        EasingInOutFunction = (t) => { return -(Math.Cos(Math.PI * t) - 1) / 2; };
    }
}
