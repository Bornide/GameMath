using GameMath.Core.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween2D<TIn> : TweenSequence<TIn, Point2D<decimal>>
{
    protected override Simple.TweenSimple<TIn, Point2D<decimal>> CreateInstance() => new Simple.Tween2D<TIn>();
}
