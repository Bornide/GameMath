using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ITo2D<TIn, TOut>
    {
        IFor<TIn, TOut> To(TIn x, TIn y);
    }
}
