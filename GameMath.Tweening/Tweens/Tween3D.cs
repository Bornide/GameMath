using GameMath.Core.Geometry;

namespace GameMath.Tweening.Tweens;

class Tween3D<TIn> : Tween<TIn, Point3D<decimal>>
{
    public override Point3D<decimal> Update(double currentTime)
    {
        var result = Interpolation.Interpolate(this, UpdateTime(currentTime));
        return new Point3D<decimal>() { X = Convert.ToDecimal(result[0]), Y = Convert.ToDecimal(result[1]), Z = Convert.ToDecimal(result[2]) };
    }
}
