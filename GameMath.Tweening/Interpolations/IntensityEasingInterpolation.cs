using System.ComponentModel.DataAnnotations;

namespace GameMath.Tweening.Interpolations
{
    abstract class IntensityEasingInterpolation<TIn, TOut> : EasingInterpolation<TIn, TOut>
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
