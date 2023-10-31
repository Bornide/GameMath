using GameMath.Core;
using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ITo3D<TIn, TOut>
    {
        IFor<TIn, TOut> To(TIn x, TIn y, TIn z);
        IFor<TIn, TOut> To(Point3D<TIn> endvalue);
    }
}
