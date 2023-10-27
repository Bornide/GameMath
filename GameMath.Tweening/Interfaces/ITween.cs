using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening
{
    public interface ITween<T>
    {
        void Start();
        T Update(double currentTime);
        void Restart();
        void Reverse();
        void Stop();
    }
}
