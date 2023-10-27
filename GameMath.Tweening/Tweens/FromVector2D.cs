using GameMath.Core.Exceptions.FluentBuilder;
using GameMath.Tweening.Vector2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens
{
    class FromVector2D : Tween, ITweenVector2D, IFrom, ITo, IFor, IInterpolation, IEase, IBuild
    {
        public Vectors.Short.Vector2D Update(double currentTime)
        {
            if (!IsBuilded) throw new UnbuildException();
            if (!IsStarted) return StartValue!;

            CurrentDuration = Math.Min(CurrentDuration + currentTime, TotalDuration);
            return Interpolation!.Interpolate2D(this, CurrentDuration);
        }

        public ITo From(short x, short y) { StartValue = new Vectors.Short.Vector2D(x, y); return this; }
        public ITo From(int x, int y) => From2D(x, y);
        public ITo From(long x, long y) => From2D(x, y);
        public ITo From(float x, float y) => From2D(x, y);
        public ITo From(double x, double y) => From2D(x, y);
        public ITo From(decimal x, decimal y) => From2D(x, y);

        public IFor To(short x, short y) => To2D(x, y);
        public IFor To(int x, int y) => To2D(x, y);
        public IFor To(long x, long y) => To2D(x, y);
        public IFor To(float x, float y) => To2D(x, y);
        public IFor To(double x, double y) => To2D(x, y);
        public IFor To(decimal x, decimal y) => To2D(x, y);

        public IInterpolation For(double duration)
        {
            TotalDuration = duration;
            return this;
        }

        public IBuild Linear()
        {
            Interpolation = new Linear();
            return this;
        }

        public IEase Cubic()
        {
            Interpolation = new Cubic();
            return this;
        }

        public IEase Elastic()
        {
            Interpolation = new Elastic();
            return this;
        }

        public IEase Quadratic()
        {
            Interpolation = new Quadratic();
            return this;
        }

        public IBuild EaseIn()
        {
            Interpolation!.EaseingFunction = new EaseIn();
            return this;
        }

        public IBuild EaseOut()
        {
            Interpolation!.EaseingFunction = new EaseOut();
            return this;
        }

        public IBuild EaseInOut()
        {
            Interpolation!.EaseingFunction = new EaseInOut();
            return this;
        }

        public ITweenVector2D Build()
        {
            IsBuilded = true;
            return this;
        }
    }
}
