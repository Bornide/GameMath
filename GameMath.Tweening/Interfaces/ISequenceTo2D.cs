using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ISequenceTo2D<TIn, TOut>
    {
        ISequenceTo2D<TIn, TOut> Add(Point2D<TIn> value);
        ISequenceTo2D<TIn, TOut> Add(System.Drawing.Point value);
        ISequenceTo2D<TIn, TOut> Add(Microsoft.Xna.Framework.Point value);
        ISequenceTo2D<TIn, TOut> Add(System.Drawing.PointF value);
        IInterpolation<TIn, TOut> For(double duration);
        IInterpolation<TIn, TOut> For(params double[] durations);
        IInterpolation<TIn, TOut> For(ICollection<double> durations);
    }
}
