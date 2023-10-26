using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vectors.Short
{
    public class Vector3D
    {
        public short X { get; set; }
        public short Y { get; set; }
        public short Z { get; set; }

        public Vector3D(short x, short y, short z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
