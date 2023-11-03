using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ITweenSequenceFor<TIn, TOut>
    {
        ITweenSequenceFor<TIn, TOut> Add(TIn value);
        ITweenSequenceFor<TIn, TOut> Add(Point2D<TIn> value);
        ITweenSequenceFor<TIn, TOut> Add(System.Drawing.Point value);
        ITweenSequenceFor<TIn, TOut> Add(Microsoft.Xna.Framework.Point value);
        ITweenSequenceFor<TIn, TOut> Add(System.Drawing.PointF value);
        ITweenSequenceFor<TIn, TOut> Add(Point3D<TIn> value);
        IInterpolation<TIn, TOut> For(double duration);
        IInterpolation<TIn, TOut> For(params double[] durations);
        IInterpolation<TIn, TOut> For(ICollection<double> durations);
    }
}
