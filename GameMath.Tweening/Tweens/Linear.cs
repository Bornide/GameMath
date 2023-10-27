namespace GameMath.Tweening.Tweens
{
    class Linear : Interpolation<dynamic>
    {
        public Linear() : base() { }

        public override dynamic Interpolate(Tween<dynamic> tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();

            return (tween.EndValues - tween.StartValues) * (currentDuration / tween.TotalDuration) + tween.StartValues;
        }
    }
}
