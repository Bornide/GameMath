using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Vectors.Decimal
{
    public class Vector2D
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }

        public Vector2D(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }
    }
}
