using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interpolations
{
    abstract class IntensityEasingInterpolation<TOut> : EasingInterpolation<TOut>
    {
        [Range(0, 20)]
        protected double Intensity { get; set; } = 1;
        protected void SetIntensity(double intensity)
        {
            if(intensity < 0 || intensity > 20) throw new ArgumentOutOfRangeException(nameof(intensity));
            Intensity = intensity;
        }
    }
}
