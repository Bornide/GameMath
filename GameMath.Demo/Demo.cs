using GameMath.Tweening;
using GameMath.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameMath.Core.Extensions;

namespace GameMath.Demo
{
    public class Demo : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _rectangle;
        private int _easeInX;
        private int _easeOutX;
        private int _easeInOutX;
        private ITween<int, decimal> _easeInTween;
        private ITween<int, decimal> _easeOutTween;
        private ITween<int, decimal> _easeInOutTween;

        public Demo()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _easeInTween = TweenBuilder.From(100).To(600).For(1000f).Back(3).EaseIn().Build();
            _easeOutTween = TweenBuilder.From(100).To(600).For(1000f).Back(3).EaseOut().Build();
            _easeInOutTween = TweenBuilder.From(100).To(600).For(1000f).Back(3).EaseInOut().Build();
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
                _easeInTween.Start();
                _easeOutTween.Start();
                _easeInOutTween.Start();
            }
            if (Keyboard.GetState().IsKeyDown(Keys.R))
            {
                _easeInTween.Restart();
                _easeOutTween.Restart();
                _easeInOutTween.Restart();
            }

            _easeInX = _easeInTween.Update(gameTime.ElapsedGameTime.Milliseconds).ToInt();
            _easeOutX = _easeOutTween.Update(gameTime.ElapsedGameTime.Milliseconds).ToInt();
            _easeInOutX = _easeInOutTween.Update(gameTime.ElapsedGameTime.Milliseconds).ToInt();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(20, 20, 20));
            _spriteBatch.Begin();
            _spriteBatch.Draw(_rectangle, new Rectangle(_easeInX, 50, 50, 50), Color.White);
            _spriteBatch.Draw(_rectangle, new Rectangle(_easeOutX, 200, 50, 50), Color.White);
            _spriteBatch.Draw(_rectangle, new Rectangle(_easeInOutX, 350, 50, 50), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}