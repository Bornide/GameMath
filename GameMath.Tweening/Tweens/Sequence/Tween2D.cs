using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween2D<TIn> : TweenSequence<TIn, Point2D<decimal>>
{
    protected override Point2D<decimal> Interpolate(double currentTime)
    {
        var result = Interpolation.Interpolate(this, CurrentDuration);
        return new Point2D<decimal>() { X = Convert.ToDecimal(result[0]), Y = Convert.ToDecimal(result[1]) };
    }
}
