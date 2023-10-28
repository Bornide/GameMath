using GameMath.Tweening.Tweens;

namespace GameMath.Tweening.Interpolations;

class Linear : Interpolation
{
    public override double[] Interpolate(Tween<short, double> tween, double currentDuration)
    {
        double[] result = new double[tween.StartValues.Length];
        for(int i = 0; i< tween.StartValues.Length; i++)
            result[i] = (tween.EndValues[i] - tween.StartValues[i]) * (currentDuration / tween.TotalDuration) + tween.StartValues[i];
        return result;
    }

    public override double[] Interpolate(Tween<int, double> tween, double currentDuration)
    {
        double[] result = new double[tween.StartValues.Length];
        for (int i = 0; i < tween.StartValues.Length; i++)
            result[i] = (tween.EndValues[i] - tween.StartValues[i]) * (currentDuration / tween.TotalDuration) + tween.StartValues[i];
        return result;
    }

    public override double[] Interpolate(Tween<long, double> tween, double currentDuration)
    {
        double[] result = new double[tween.StartValues.Length];
        for (int i = 0; i < tween.StartValues.Length; i++)
            result[i] = (tween.EndValues[i] - tween.StartValues[i]) * (currentDuration / tween.TotalDuration) + tween.StartValues[i];
        return result;
    }

    public override double[] Interpolate(Tween<float, double> tween, double currentDuration)
    {
        double[] result = new double[tween.StartValues.Length];
        for (int i = 0; i < tween.StartValues.Length; i++)
            result[i] = (tween.EndValues[i] - tween.StartValues[i]) * (currentDuration / tween.TotalDuration) + tween.StartValues[i];
        return result;
    }

    public override double[] Interpolate(Tween<double, double> tween, double currentDuration)
    {
        double[] result = new double[tween.StartValues.Length];
        for (int i = 0; i < tween.StartValues.Length; i++)
            result[i] = (tween.EndValues[i] - tween.StartValues[i]) * (currentDuration / tween.TotalDuration) + tween.StartValues[i];
        return result;
    }

    public override decimal[] Interpolate(Tween<decimal, decimal> tween, double currentDuration)
    {
        decimal[] result = new decimal[tween.StartValues.Length];
        for (int i = 0; i < tween.StartValues.Length; i++)
            result[i] = (tween.EndValues[i] - tween.StartValues[i]) * (decimal)(currentDuration / tween.TotalDuration) + tween.StartValues[i];
        return result;
    }
}
