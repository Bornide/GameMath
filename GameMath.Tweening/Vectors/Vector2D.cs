using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vectors
{
    public class Vector2D
    {
        public dynamic X { get; set; }
        public dynamic Y { get; set; }

        public Vector2D(dynamic x, dynamic y)
        {
            X = x;
            Y = y;
        }
    }
}
