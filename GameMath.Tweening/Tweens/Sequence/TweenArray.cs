using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class TweenArray<TIn> : TweenSequence<TIn, decimal[]>
{
    protected override Simple.TweenSimple<TIn, decimal[]> CreateInstance() => new Simple.TweenArray<TIn>();
}
