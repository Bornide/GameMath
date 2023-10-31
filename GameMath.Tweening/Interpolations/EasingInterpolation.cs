using GameMath.Core.Enums;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class EasingInterpolation<TIn, TOut> : Interpolation<TIn, TOut>
{
    public Ease EasingType { get; set; }
    protected abstract Func<double, double> EasingInFunction { get; }
    protected abstract Func<double, double> EasingOutFunction { get; }
    protected abstract Func<double, double> EasingInOutFunction { get; }

    public override decimal[] Interpolate(Tween<TIn, TOut> tween, double currentDuration)
    {
        switch (EasingType)
        {
            case Ease.EaseIn:
                return Interpolate(EasingInFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);
            case Ease.EaseOut:
                return Interpolate(EasingOutFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);
            case Ease.EaseInOut:
                return Interpolate(EasingInOutFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);
            default:
                throw new Exception("Easing type invalid or null");
        }
    }

    private decimal[] Interpolate(Func<double, double> EasingFunction, TIn[] startValues, TIn[] endValues, double currentDuration, double totalDuration)
    {
        double t = currentDuration / totalDuration;
        double tweenValue = EasingFunction(t);

        ResultBuffer ??= new decimal[startValues.Length];
        for (int i = 0; i < startValues.Length; i++)
            ResultBuffer[i] = Convert.ToDecimal(startValues[i]) + (Convert.ToDecimal(endValues[i]) - Convert.ToDecimal(startValues[i])) * Convert.ToDecimal(tweenValue);
        return ResultBuffer;
    }
}
