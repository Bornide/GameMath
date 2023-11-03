using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class TweenArray<TIn> : TweenSequence<TIn, decimal[]>
{
    protected override decimal[] Interpolate(double currentTime)
    {
        return Interpolation.Interpolate(this, CurrentDuration);
    }
}
