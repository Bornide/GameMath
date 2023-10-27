using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens
{
    abstract class EasingInterpolation<T> : Interpolation<T>
    {
        public Ease<T> EaseingFunction { get; set; }
        public EasingInterpolation() { }

        protected EasingInterpolation(Ease<T> easeingFunction) : base()
        {
            EaseingFunction = easeingFunction;
        }
    }
}
