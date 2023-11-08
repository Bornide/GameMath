using GameMath.Tweening.Tweens;
using GameMath.Tweening.Tweens.Simple;

namespace GameMath.Tweening.Interpolations;

class Linear<TIn, TOut> : Interpolation<TIn, TOut>
{
    public override decimal[] Interpolate(TweenSimple<TIn, TOut> tween, double currentDuration)
        => Interpolate(tween.StartValues, tween.EndValues, currentDuration, tween.TotalDuration);

    private decimal[] Interpolate(TIn[] startValues, TIn[] endValues, double currentDuration, double totalDuration)
    {
        ResultBuffer ??= new decimal[startValues.Length];
        for (int i = 0; i < startValues.Length; i++)
            ResultBuffer[i] = (Convert.ToDecimal(endValues[i]) - Convert.ToDecimal(startValues[i])) * 
                Convert.ToDecimal(currentDuration / totalDuration) +
                Convert.ToDecimal(startValues[i]);
        return ResultBuffer;
    }
}
