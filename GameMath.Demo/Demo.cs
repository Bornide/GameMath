﻿using GameMath.Tweening;
using GameMath.Tweening.SingleValue;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameMath.Demo
{
    public class Demo : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D _rectangle;
        private double _linearX;
        private double _elasticX;
        private ITweenShort _linearTween;
        private ITweenShort _elasticTween;

        public Demo()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _linearTween = TweenBuilder.From(100, 100).To(600, 600).For(1000f).Linear().Build();
            _elasticTween = TweenBuilder.From(100).To(600).For(1000f).Elastic().EaseInOut().Build();
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
                _linearTween.Start();
                _elasticTween.Start();
            }

            System.Drawing.Point p = new System.Drawing.Point();

            p.X = _linearTween.Update(gameTime.ElapsedGameTime.Milliseconds);
            _elasticX = _elasticTween.Update(gameTime.ElapsedGameTime.Milliseconds);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(20, 20, 20));
            _spriteBatch.Begin();
            _spriteBatch.Draw(_rectangle, new Rectangle((int)_linearX, 50, 50, 50), Color.White);
            _spriteBatch.Draw(_rectangle, new Rectangle((int)_elasticX, 150, 50, 50), Color.White);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}