using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Float;

class Tween : Tween<float, decimal>
{
    public override decimal Update(double currentTime)
    {
        return Interpolation.Interpolate(this, UpdateTime(currentTime))[0];
    }
}
