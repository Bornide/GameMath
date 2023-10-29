using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Long;

class Tween2D : Tween<long, Point2D<decimal>>
{
    public override Point2D<decimal> Update(double currentTime)
    {
        var result = Interpolation.Interpolate(this, UpdateTime(currentTime));
        return new Point2D<decimal>() { X = result[0], Y = result[1] };
    }
}
