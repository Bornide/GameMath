using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ISequenceTo<TIn, TOut>
    {
        ISequenceTo<TIn, TOut> Add(TIn value);
        IInterpolation<TIn, TOut> For(double duration);
        IInterpolation<TIn, TOut> For(params double[] durations);
        IInterpolation<TIn, TOut> For(ICollection<double> durations);
    }
}
