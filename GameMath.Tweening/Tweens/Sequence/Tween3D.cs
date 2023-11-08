using GameMath.Core.Geometry;
using GameMath.Tweening.Interpolations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens.Sequence;

class Tween3D<TIn> : TweenSequence<TIn, Point3D<decimal>>
{
    protected override Simple.TweenSimple<TIn, Point3D<decimal>> CreateInstance() => new Simple.Tween3D<TIn>();
}
