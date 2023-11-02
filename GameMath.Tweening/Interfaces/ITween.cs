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
        void Start();
        /// <summary>
        /// Update tween step and returns current value
        /// </summary>
        TOut Update(double currentTime);
        /// <summary>
        /// Reset time elapsed
        /// </summary>
        void Reset();
        /// <summary>
        /// Reset time elapsed then start the tween
        /// </summary>
        void Restart();
        /// <summary>
        /// Swap endValues and startvalues
        /// </summary>
        void Reverse();
        /// <summary>
        /// Pause the tween (doesn't reset time elapsed)
        /// </summary>
        void Pause();
        /// <summary>
        /// Stop the tween (reset time elapsed)
        /// </summary>
        void Stop();
        /// <summary>
        /// Toggle the start/stop state of the tween
        /// </summary>
        void ToggleState();
    }
}
