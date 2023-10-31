using GameMath.Core;
using GameMath.Core.Geometry;
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
        IFor<TIn, TOut> To(Point2D<TIn> endValue);
        IFor<TIn, TOut> To(System.Drawing.Point endValue);
        IFor<TIn, TOut> To(Microsoft.Xna.Framework.Point endValue);
        IFor<TIn, TOut> To(System.Drawing.PointF endValue);
    }
}
