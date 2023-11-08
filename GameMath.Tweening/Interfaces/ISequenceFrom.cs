using GameMath.Core.Geometry;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ISequenceFrom<TIn, TOut>
    {
        ISequenceTo<TIn, TOut> Add(TIn value);
        ISequenceTo2D<TIn, TOut> Add(Point2D<TIn> value);
        ISequenceTo2D<TIn, TOut> Add(System.Drawing.Point value);
        ISequenceTo2D<TIn, TOut> Add(Microsoft.Xna.Framework.Point value);
        ISequenceTo2D<TIn, TOut> Add(System.Drawing.PointF value);
        ISequenceTo3D<TIn, TOut> Add(Point3D<TIn> value);
        ISequenceFor<TIn, TOut> AddRange(ICollection<TIn> values);
        ISequenceFor<TIn, TOut> AddRange(ICollection<Point2D<TIn>> values);
        ISequenceFor<TIn, TOut> AddRange(ICollection<System.Drawing.Point> values);
        ISequenceFor<TIn, TOut> AddRange(ICollection<Microsoft.Xna.Framework.Point> values);
        ISequenceFor<TIn, TOut> AddRange(ICollection<System.Drawing.PointF> values);
        ISequenceFor<TIn, TOut> AddRange(ICollection<Point3D<TIn>> values);
    }
}
