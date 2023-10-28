using GameMath.Core;
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
        /*ITo<int> From(int startValue);
        ITo<long> From(long startValue);
        ITo<float> From(float startValue);
        ITo<double> From(double startValue);
        ITo<decimal> From(decimal startValue);

        ITo2D<short> From(short x, short y);
        ITo2D<int> From(int x, int y);
        ITo2D<long> From(long x, long y);
        ITo2D<float> From(float x, float y);
        ITo2D<double> From(double x, double y);
        ITo2D<decimal> From(decimal x, decimal y);

        ITo3D<short> From(short x, short y, short z);
        ITo3D<int> From(int x, int y, int z);
        ITo3D<long> From(long x, long y, long z);
        ITo3D<float> From(float x, float y, float z);
        ITo3D<double> From(double x, double y, double z);
        ITo3D<decimal> From(decimal x, decimal y, decimal z);*/
    }
}
