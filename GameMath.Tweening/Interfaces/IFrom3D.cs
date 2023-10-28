using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IFrom3D<TIn, TOut>
    {
        ITo3D<TIn, TOut> From(TIn x, TIn y, TIn z);
    }
}
