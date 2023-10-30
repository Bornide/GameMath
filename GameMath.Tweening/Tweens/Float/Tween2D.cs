using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Float;

class Tween2D : Tween<float, Point2D<decimal>>
{
    public override Point2D<decimal> Update(double currentTime)
    {
        var result = Interpolation.Interpolate(this, UpdateTime(currentTime));
        return new Point2D<decimal>() { X = result[0], Y = result[1] };
    }
}
