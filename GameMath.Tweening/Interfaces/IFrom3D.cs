using GameMath.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IFrom3D
    {
        ITo3D<short> From(short x, short y, short z);
        ITo3D<int> From(int x, int y, int z);
        ITo3D<long> From(long x, long y, long z);
        ITo3D<float> From(float x, float y, float z);
        ITo3D<double> From(double x, double y, double z);
        ITo3D<decimal> From(decimal x, decimal y, decimal z);
    }
}
