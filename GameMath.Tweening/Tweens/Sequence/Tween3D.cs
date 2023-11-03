using GameMath.Core.Geometry;
using GameMath.Tweening.Interpolations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween3D<TIn> : TweenSequence<TIn, Point3D<decimal>>
{
    protected override Point3D<decimal> Interpolate(double currentTime)
    {
        var result = Interpolation.Interpolate(this, CurrentDuration);
        return new Point3D<decimal>() { X = Convert.ToDecimal(result[0]), Y = Convert.ToDecimal(result[1]), Z = Convert.ToDecimal(result[2]) };
    }
}
