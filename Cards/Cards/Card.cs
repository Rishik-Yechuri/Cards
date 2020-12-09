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
    public class Card
    {
        Texture2D cardTexture;
        Rectangle cardRectangle;

        public Card(ContentManager c, String contentName, Rectangle rectangle)
        {
            cardTexture = c.Load<Texture2D>(contentName);
            cardRectangle = rectangle;
        }

        public void Draw(GraphicsDevice graphicsDevice)
        {
            SpriteBatch sb = new SpriteBatch(graphicsDevice);
            sb.Begin();
            sb.Draw(cardTexture, cardRectangle, Color.White);
            sb.End();
        }
    }
}
