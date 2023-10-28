using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IFrom2D<TIn, TOut>
    {
        ITo2D<TIn, TOut> From(TIn x, TIn y);
    }
}
