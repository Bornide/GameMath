using GameMath.Core.Geometry;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ITweenSequence<TIn, TOut>
    {
        ITweenSequenceFor<TIn, TOut> Add(TIn value);
        ITweenSequence2DFor<TIn, TOut> Add(Point2D<TIn> value);
        ITweenSequence2DFor<TIn, TOut> Add(System.Drawing.Point value);
        ITweenSequence2DFor<TIn, TOut> Add(Microsoft.Xna.Framework.Point value);
        ITweenSequence2DFor<TIn, TOut> Add(System.Drawing.PointF value);
        ITweenSequence3DFor<TIn, TOut> Add(Point3D<TIn> value);
        IForSequence<TIn, TOut> AddRange(ICollection<TIn> values);
        IForSequence<TIn, TOut> AddRange(ICollection<Point2D<TIn>> values);
        IForSequence<TIn, TOut> AddRange(ICollection<System.Drawing.Point> values);
        IForSequence<TIn, TOut> AddRange(ICollection<Microsoft.Xna.Framework.Point> values);
        IForSequence<TIn, TOut> AddRange(ICollection<System.Drawing.PointF> values);
        IForSequence<TIn, TOut> AddRange(ICollection<Point3D<TIn>> values);
    }
}
