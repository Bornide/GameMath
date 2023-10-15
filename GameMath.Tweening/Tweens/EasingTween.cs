
namespace GameMath.Tweening
{
    abstract class EasingTween : Tween, IEase
    {
        protected Ease Ease;

        public IFrom EaseIn()
        {
            Ease = new EaseIn();
            return this;
        }

        public IFrom EaseInOut()
        {
            Ease = new EaseInOut();
            return this;
        }

        public IFrom EaseOut()
        {
            Ease = new EaseOut();
            return this;
        }
    }
}
