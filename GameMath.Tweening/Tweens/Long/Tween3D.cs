using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Long;

class Tween3D : Tween<long, Point3D<decimal>>
{
    public override Point3D<decimal> Update(double currentTime)
    {
        var result = Interpolation.Interpolate(this, UpdateTime(currentTime));
        return new Point3D<decimal>() { X = result[0], Y = result[1], Z = result[2] };
    }
}
