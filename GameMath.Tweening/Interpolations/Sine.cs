namespace GameMath.Tweening.Interpolations;

class Sine<TIn, TOut> : EasingInterpolation<TIn, TOut>
{
    protected override Func<double, double> EasingInFunction => (t) => { return 1 - Math.Cos((t * Math.PI) / 2); };
    protected override Func<double, double> EasingOutFunction => (t) => { return Math.Sin((t * Math.PI) / 2); };
    protected override Func<double, double> EasingInOutFunction => (t) => { return -(Math.Cos(Math.PI * t) - 1) / 2; };
}
