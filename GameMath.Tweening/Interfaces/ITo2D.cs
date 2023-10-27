using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface ITo2D<T>
    {
        IFor<Point2D<T>> To(T x, T y);
    }
}
