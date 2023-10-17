using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vector2D
{
    public interface IInterpolation
    {
        IBuild Linear();
        IEase Cubic();
        IEase Elastic();
        IEase Quadratic();
    }
}
