using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Point
{
    public interface IInterpolation
    {
        IBuild Linear();
        IEase Cubic();
        IEase Elastic();
        IEase Quadratic();
    }
}
