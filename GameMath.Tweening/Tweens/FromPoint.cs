using GameMath.Core.Exceptions.FluentBuilder;
using GameMath.Tweening.SingleValue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMath.Tweening.Tweens
{
    class FromPoint : Tween, ITweenShort, IFrom, ITo, IFor, IInterpolation, IEase, IBuild
    {
        public dynamic Update(double currentTime)
        {
            if (!IsBuilded) throw new UnbuildException();
            if (!IsStarted) return StartValue!;

            CurrentDuration = Math.Min(CurrentDuration + currentTime, TotalDuration);
            return Interpolation!.Interpolate(this, CurrentDuration);
        }
        public ITo From(short startValue) => FromValue(startValue);
        public ITo From(int startValue) => FromValue(startValue);
        public ITo From(long startValue) => FromValue(startValue);
        public ITo From(float startValue) => FromValue(startValue);
        public ITo From(double startValue) => FromValue(startValue);
        public ITo From(decimal startValue) => FromValue(startValue);

        public IFor To(short endValue) => ToValue(endValue);
        public IFor To(int endValue) => ToValue(endValue);
        public IFor To(long endValue) => ToValue(endValue);
        public IFor To(float endValue) => ToValue(endValue);
        public IFor To(double endValue) => ToValue(endValue);
        public IFor To(decimal endValue) => ToValue(endValue);

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

        public ITweenShort Build()
        {
            IsBuilded = true;
            return this;
        }

        private ITo FromValue(dynamic startValue)
        {
            StartValue = startValue;
            return this;
        }

        private IFor ToValue(dynamic endValue)
        {
            EndValue = endValue;
            return this;
        }
    }
}
