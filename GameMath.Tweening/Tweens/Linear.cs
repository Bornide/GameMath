namespace GameMath.Tweening.Tweens
{
    class Linear : Interpolation
    {
        public Linear() : base() { }

        public override dynamic Interpolate(Tween tween, double currentDuration)
        {
            //if (currentTime >= this.TotalDuration) OnAnimationEnded();
            return (tween.EndValue - tween.StartValue) * (currentDuration / tween.TotalDuration) + tween.StartValue;
        }

        public override Vectors.Vector2D Interpolate2D(Tween tween, double currentDuration)
        {
            throw new NotImplementedException();
        }
    }
}
