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
        ITweenSequenceAdd<TIn, TOut> Add(TIn value);
        ITweenSequenceAdd<TIn, TOut> Add(Point2D<TIn> value);
        ITweenSequenceAdd<TIn, TOut> Add(System.Drawing.Point value);
        ITweenSequenceAdd<TIn, TOut> Add(Microsoft.Xna.Framework.Point value);
        ITweenSequenceAdd<TIn, TOut> Add(System.Drawing.PointF value);
        ITweenSequenceAdd<TIn, TOut> Add(Point3D<TIn> value);
        IFor<TIn, TOut> AddRange(ICollection<TIn> values);
        IFor<TIn, TOut> AddRange(ICollection<Point2D<TIn>> values);
        IFor<TIn, TOut> AddRange(ICollection<System.Drawing.Point> values);
        IFor<TIn, TOut> AddRange(ICollection<Microsoft.Xna.Framework.Point> values);
        IFor<TIn, TOut> AddRange(ICollection<System.Drawing.PointF> values);
        IFor<TIn, TOut> AddRange(ICollection<Point3D<TIn>> values);
    }
}
