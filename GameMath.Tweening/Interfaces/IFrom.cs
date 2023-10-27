using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Interfaces
{
    public interface IFrom
    {
        ITo From(short startValue);
        ITo From(int startValue);
        ITo From(long startValue);
        ITo From(float startValue);
        ITo From(double startValue);
        ITo From(decimal startValue);

        ITo From(short x, short y);
        ITo From(int x, int y);
        ITo From(long x, long y);
        ITo From(float x, float y);
        ITo From(double x, double y);
        ITo From(decimal x, decimal y);
    }
}
