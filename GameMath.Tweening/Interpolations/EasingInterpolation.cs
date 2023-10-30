using GameMath.Core.Extensions;
using GameMath.Tweening.Eases;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

abstract class EasingInterpolation<TOut> : Interpolation<TOut>
{
    public Ease<TOut> EasingFunction { get; set; }
    protected virtual Func<double, double> EasingInFunction { get; set; }
    protected virtual Func<double, double> EasingOutFunction { get; set; }
    protected virtual Func<double, double> EasingInOutFunction { get; set; }    

    public override decimal[] Interpolate(Tween<short, TOut> tween, double currentDuration) 
        => EasingFunction.Interpolate(this, tween, currentDuration);

    public override decimal[] Interpolate(Tween<int, TOut> tween, double currentDuration)
        => EasingFunction.Interpolate(this, tween, currentDuration);

    public override decimal[] Interpolate(Tween<long, TOut> tween, double currentDuration)
        => EasingFunction.Interpolate(this, tween, currentDuration);

    public override decimal[] Interpolate(Tween<float, TOut> tween, double currentDuration)
        => EasingFunction.Interpolate(this, tween, currentDuration);

    public override decimal[] Interpolate(Tween<double, TOut> tween, double currentDuration)
        => EasingFunction.Interpolate(this, tween, currentDuration);

    public override decimal[] Interpolate(Tween<decimal, TOut> tween, double currentDuration)
        => EasingFunction.Interpolate(this, tween, currentDuration);

    public decimal[] Interpolate(EaseIn<TOut> easeIn, Tween<short, TOut> tween, double currentDuration)
        => Interpolate(EasingInFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseIn<TOut> easeIn, Tween<int, TOut> tween, double currentDuration)
        => Interpolate(EasingInFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseIn<TOut> easeIn, Tween<long, TOut> tween, double currentDuration)
        => Interpolate(EasingInFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseIn<TOut> easeIn, Tween<float, TOut> tween, double currentDuration)
        => Interpolate(EasingInFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseIn<TOut> easeIn, Tween<double, TOut> tween, double currentDuration)
        => Interpolate(EasingInFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseIn<TOut> easeIn, Tween<decimal, TOut> tween, double currentDuration)
        => Interpolate(EasingInFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseOut<TOut> easeOut, Tween<short, TOut> tween, double currentDuration)
        => Interpolate(EasingOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseOut<TOut> easeOut, Tween<int, TOut> tween, double currentDuration)
        => Interpolate(EasingOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseOut<TOut> easeOut, Tween<long, TOut> tween, double currentDuration)
        => Interpolate(EasingOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseOut<TOut> easeOut, Tween<float, TOut> tween, double currentDuration)
        => Interpolate(EasingOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseOut<TOut> easeOut, Tween<double, TOut> tween, double currentDuration)
        => Interpolate(EasingOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseOut<TOut> easeOut, Tween<decimal, TOut> tween, double currentDuration)
        => Interpolate(EasingOutFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseInOut<TOut> easeInOut, Tween<short, TOut> tween, double currentDuration)
        => Interpolate(EasingInOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseInOut<TOut> easeInOut, Tween<int, TOut> tween, double currentDuration)
        => Interpolate(EasingInOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseInOut<TOut> easeInOut, Tween<long, TOut> tween, double currentDuration)
        => Interpolate(EasingInOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseInOut<TOut> easeInOut, Tween<float, TOut> tween, double currentDuration)
        => Interpolate(EasingInOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseInOut<TOut> easeInOut, Tween<double, TOut> tween, double currentDuration)
        => Interpolate(EasingInOutFunction, tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public decimal[] Interpolate(EaseInOut<TOut> easeInOut, Tween<decimal, TOut> tween, double currentDuration)
        => Interpolate(EasingInOutFunction, tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);

    protected decimal[] Interpolate(Func<double, double> EasingFunction, decimal[] startValues, decimal[] endValues, double currentDuration, double totalDuration)
    {
        double t = currentDuration / totalDuration;
        double tweenValue = EasingFunction(t);

        if(ResultBuffer == null) ResultBuffer = new decimal[startValues.Length];
        for (int i = 0; i < startValues.Length; i++)
            ResultBuffer[i] = startValues[i] + (endValues[i] - startValues[i]) * Convert.ToDecimal(tweenValue);
        return ResultBuffer;
    }
}
