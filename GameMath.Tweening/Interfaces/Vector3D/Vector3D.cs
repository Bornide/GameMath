using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vector3D
{
    public class Vector3D
    {
        public dynamic X { get; set; }
        public dynamic Y { get; set; }
        public dynamic Z { get; set; }

        public Vector3D(dynamic x, dynamic y, dynamic z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
