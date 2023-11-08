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
        event TweenEvent? AnimationEnded;
        /// <summary>
        /// Start the tween from current time elapsed
        /// </summary>
        ITween<TIn, TOut> Start();
        /// <summary>
        /// Update tween step and returns current value
        /// </summary>
        TOut Update(double currentTime);
        /// <summary>
        /// Reset time elapsed
        /// </summary>
        ITween<TIn, TOut> Reset();
        /// <summary>
        /// Reset time elapsed then start the tween
        /// </summary>
        ITween<TIn, TOut> Restart();
        /// <summary>
        /// Swap endValues and startvalues
        /// </summary>
        ITween<TIn, TOut> Reverse();
        /// <summary>
        /// Pause the tween (doesn't reset time elapsed)
        /// </summary>
        ITween<TIn, TOut> Pause();
        /// <summary>
        /// Stop the tween (reset time elapsed)
        /// </summary>
        ITween<TIn, TOut> Stop();
        /// <summary>
        /// Toggle the start/stop state of the tween
        /// </summary>
        ITween<TIn, TOut> ToggleState();
    }
}
