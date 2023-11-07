using GameMath.Tweening.Interpolations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween<TIn> : TweenSequence<TIn, decimal>
{
    protected override decimal Interpolate(double currentTime)
    {
        return Interpolation.Interpolate(this, CurrentDuration)[0];
    }

    public override ITween<TIn, decimal> Build()
    {
        if (Values.Count < 2)
            throw new ArgumentException("Not enough values for the tween sequence");
        TotalDuration = TotalDurations[CurrentStepIndex];

        for(int i=0; i<Values.Count-1; i++)
        {
            var t = new Simple.Tween<TIn>();
            t.From(Values[i]);
            t.To(Values[i]);
            t.For(TotalDurations[i]);
            t.Interpolation = this.Interpolation;
            Tweens.Add(t);
        }

        return base.Build();
    }
}
