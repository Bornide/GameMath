using GameMath.Core.Geometry;

namespace GameMath.Tweening.Tweens;

class Tween2D<TIn> : Tween<TIn, Point2D<decimal>>
{
    public override Point2D<decimal> Update(double currentTime)
    {
        var result = Interpolation.Interpolate(this, UpdateTime(currentTime));
        return new Point2D<decimal>() { X = Convert.ToDecimal(result[0]), Y = Convert.ToDecimal(result[1]) };
    }
}
