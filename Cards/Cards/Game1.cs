using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Cards
{
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Card tenOfSpades;
        Card aceOfDiamonds;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            tenOfSpades = new Card(this.Content, "10ofSpades", new Rectangle(50, 50, 142, 212));
            aceOfDiamonds = new Card(this.Content, "AceofDiamonds", new Rectangle(200, 50, 142, 212));

            base.Initialize();
        }
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
                this.Exit();
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            // TODO: Add your drawing code here
            tenOfSpades.Draw(graphics.GraphicsDevice);
            aceOfDiamonds.Draw(graphics.GraphicsDevice);
            base.Draw(gameTime);
        }
    }
}
