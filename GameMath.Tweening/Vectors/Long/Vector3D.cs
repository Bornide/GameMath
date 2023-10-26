using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vectors.Long
{
    public class Vector3D
    {
        public long X { get; set; }
        public long Y { get; set; }
        public long Z { get; set; }

        public Vector3D(long x, long y, long z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
