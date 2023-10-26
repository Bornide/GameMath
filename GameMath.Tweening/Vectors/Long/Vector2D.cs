using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vectors.Long
{
    public class Vector2D
    {
        public long X { get; set; }
        public long Y { get; set; }

        public Vector2D(long x, long y)
        {
            X = x;
            Y = y;
        }
    }
}
