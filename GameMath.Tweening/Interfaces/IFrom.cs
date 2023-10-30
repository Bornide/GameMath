using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IFrom<TIn, TOut>
    {
        ITo<TIn, TOut> From(TIn startValue);
        ITo2D<TIn, TOut> From(TIn x, TIn y);
        ITo3D<TIn, TOut> From(TIn x, TIn y, TIn z);
        IToCollection<TIn, TOut> From(params TIn[] startValues);
    }
}
