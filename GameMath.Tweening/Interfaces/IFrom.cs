using GameMath.Core;
using GameMath.Core.Geometry;
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
        ITo2D<TIn, TOut> From(Point2D<TIn> startValue);
        ITo2D<TIn, TOut> From(System.Drawing.Point startValue);
        ITo2D<TIn, TOut> From(Microsoft.Xna.Framework.Point startValue);
        ITo2D<TIn, TOut> From(System.Drawing.PointF startValue);
        ITo3D<TIn, TOut> From(TIn x, TIn y, TIn z);
        ITo3D<TIn, TOut> From(Point3D<TIn> startValue);
        IToCollection<TIn, TOut> From(params TIn[] startValues);
    }
}
