using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween<TIn> : TweenSequence<TIn, decimal>
{
    public override decimal Update(double currentTime)
    {
        StartValues = Values[CurrentStepIndex];
        EndValues = Values[CurrentStepIndex+1];
        var duration = UpdateTime(CurrentDuration, false);

        if (duration < TotalDurations[CurrentStepIndex])
            return Interpolation.Interpolate(this, duration)[0];

        if (CurrentStepIndex < Values.Count - 1)
            CurrentStepIndex++;
        else
            OnAnimationEnded();
        return Interpolation.Interpolate(this, duration)[0];
    }
}
