﻿using GameMath.Core.Extensions;
using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

class Linear<TOut> : Interpolation<TOut>
{
    public override decimal[] Interpolate(Tween<short, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public override decimal[] Interpolate(Tween<int, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public override decimal[] Interpolate(Tween<long, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public override decimal[] Interpolate(Tween<float, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public override decimal[] Interpolate(Tween<double, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues.ToDecimal(StartValuesBuffer), tween.EndValues.ToDecimal(EndValuesBuffer), currentDuration, tween.TotalDuration);

    public override decimal[] Interpolate(Tween<decimal, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);

    private decimal[] Interpolate(decimal[] startValues, decimal[] endValues, double currentDuration, double totalDuration)
    {
        if(ResultBuffer == null) ResultBuffer = new decimal[startValues.Length];
        for (int i = 0; i < startValues.Length; i++)
            ResultBuffer[i] = (endValues[i] - startValues[i]) * Convert.ToDecimal(currentDuration / totalDuration) + startValues[i];
        return ResultBuffer;
    }
}
