using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IFrom2D
    {
        ITo2D<short> From(short x, short y);
        ITo2D<int> From(int x, int y);
        ITo2D<long> From(long x, long y);
        ITo2D<float> From(float x, float y);
        ITo2D<double> From(double x, double y);
        ITo2D<decimal> From(decimal x, decimal y);
    }
}
