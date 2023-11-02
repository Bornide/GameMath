﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IToArray<TIn, TOut>
    {
        IFor<TIn, TOut> To(ICollection<TIn> endValues);
        IFor<TIn, TOut> To(params TIn[] endValues);
    }
}
