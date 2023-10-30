using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces;

public interface ILoop<TIn, TOut>
{
    IBuild<TIn, TOut> Loop(int waitBeforeRestart = 0);
    IBuild<TIn, TOut> LoopReverse(int waitBeforeRestart = 0);
    ITween<TIn, TOut> Build();
}
