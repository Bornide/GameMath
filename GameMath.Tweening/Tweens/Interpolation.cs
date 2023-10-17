using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens
{
    abstract class Interpolation
    {
        public Ease? EaseingFunction { get; set; }
        protected Interpolation() { }
        protected Interpolation(Ease easeingFunction)
        {
            EaseingFunction = easeingFunction;
        }

        public abstract dynamic Interpolate(Tween tween, double currentDuration);
    }
}
