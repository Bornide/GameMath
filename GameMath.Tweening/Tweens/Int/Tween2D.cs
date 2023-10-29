using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Int;

class Tween2D : Tween<int, Point2D<decimal>>
{
    public override Point2D<decimal> Update(double currentTime)
    {
        var result = Interpolation.Interpolate(this, UpdateTime(currentTime));
        return new Point2D<decimal>() { X = result[0], Y = result[1] };
    }
}
