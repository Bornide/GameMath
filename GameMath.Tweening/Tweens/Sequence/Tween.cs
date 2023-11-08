using GameMath.Tweening.Interpolations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween<TIn> : TweenSequence<TIn, decimal>
{
    protected override Simple.TweenSimple<TIn, decimal> CreateInstance() => new Simple.Tween<TIn>(); 
}
