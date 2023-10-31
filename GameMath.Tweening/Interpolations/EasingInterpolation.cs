using GameMath.Core.Enums;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class EasingInterpolation<TIn, TOut> : Interpolation<TIn, TOut>
{
    public Ease EasingFunction { get; set; }
    protected virtual Func<double, double> EasingInFunction { get; set; }
    protected virtual Func<double, double> EasingOutFunction { get; set; }
    protected virtual Func<double, double> EasingInOutFunction { get; set; }

    public override decimal[] Interpolate(Tween<TIn, TOut> tween, double currentDuration)
    {
        switch (EasingFunction)
        {
            case Ease.EaseIn:
                return Interpolate(EasingInFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);
            case Ease.EaseOut:
                return Interpolate(EasingOutFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);
            case Ease.EaseInOut:
                return Interpolate(EasingInOutFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);
            default:
                throw new Exception("Easing function invalid or null");
        }
    }

    protected decimal[] Interpolate(Func<double, double> EasingFunction, TIn[] startValues, TIn[] endValues, double currentDuration, double totalDuration)
    {
        double t = currentDuration / totalDuration;
        double tweenValue = EasingFunction(t);

        if(ResultBuffer == null) ResultBuffer = new decimal[startValues.Length];
        for (int i = 0; i < startValues.Length; i++)
            ResultBuffer[i] = Convert.ToDecimal(startValues[i]) + (Convert.ToDecimal(endValues[i]) - Convert.ToDecimal(startValues[i])) * Convert.ToDecimal(tweenValue);
        return ResultBuffer;
    }
}
