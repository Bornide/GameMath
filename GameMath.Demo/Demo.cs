using GameMath.Tweening;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameMath.Core.Extensions;
using GameMath.Core.Geometry;

namespace GameMath.Demo
{
    public class Demo : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _rectangle;
        private int _elasticX;
        private int _bounceX;
        private Point2D<int> _backPoint;
        private ITween<int, decimal> _elasticTween;
        private ITween<float, decimal> _bounceTween;
        private ITween<int, Point2D<decimal>> _backTween;

        public Demo()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _elasticTween = TweenBuilder.From(100).To(600).For(2000f).Elastic().EaseOut().LoopAlternate().Build();
            _bounceTween = TweenBuilder.From(100f).To(600f).For(2000f).Bounce().EaseOut().Build();
            _backTween = TweenBuilder.From(new Microsoft.Xna.Framework.Point() { X = 100, Y = 400 })
                .To(new Microsoft.Xna.Framework.Point() { X = 600, Y = 400 }).For(1500f).Back(1.5).EaseInOut().Build();
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice); 
            _rectangle = new Texture2D(GraphicsDevice, 1, 1);
            _rectangle.SetData(new[] { Color.MediumPurple });
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.Space))
            {
                _elasticTween.Start();
                _bounceTween.Start();
                _backTween.Start();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.R))
            {
                _elasticTween.Restart();
                _bounceTween.Restart();
                _backTween.Restart();
            }

            _elasticX = _elasticTween.Update(gameTime.ElapsedGameTime.Milliseconds).ToInt();
            _bounceX = _bounceTween.Update(gameTime.ElapsedGameTime.Milliseconds).ToInt();
            _backTween.Update(gameTime.ElapsedGameTime.Milliseconds).OutputTo(ref _backPoint);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(20, 20, 20));
            _spriteBatch.Begin();
            _spriteBatch.Draw(_rectangle, new Rectangle(_elasticX, 50, 50, 50), Color.White);
            _spriteBatch.Draw(_rectangle, new Rectangle(_bounceX, 200, 50, 50), Color.White);
            _spriteBatch.Draw(_rectangle, new Rectangle(_backPoint.X, _backPoint.Y, 50, 50), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}