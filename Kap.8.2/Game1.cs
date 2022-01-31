using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Kap._8._2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        SpriteBatch spriteBatch;
        Texture2D duck_brownBild;
        Rectangle duck_brownRectangle;

        Texture2D duck_yellowBild;
        Rectangle duck_yellowRect;

        MouseState mus;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            spriteBatch = new SpriteBatch(GraphicsDevice);
            duck_brownBild = Content.Load<Texture2D>("duck_brown");
            duck_brownRectangle = new Rectangle(100, 200, duck_brownBild.Width / 99, duck_brownBild.Height / 99);

            duck_yellowBild = Content.Load<Texture2D>("duck_yellow");
            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            
            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(duck_brownBild, duck_brownRectangle, Color.White);
            spriteBatch.Draw(duck_yellowBild, duck_yellowRect, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
