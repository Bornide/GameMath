using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening
{
    public interface ITween<TIn, TOut>
    {
        delegate void TweenEvent(ITween<TIn, TOut> tween);
        event TweenEvent AnimationEnded;
        void Start();
        TOut Update(double currentTime);
        void Restart();
        void Reverse();
        void Stop();
        void Toggle();
    }
}
