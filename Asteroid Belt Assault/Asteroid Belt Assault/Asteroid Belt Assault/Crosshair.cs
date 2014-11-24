using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace Asteroid_Belt_Assault
{
    class Crosshair
    {
        MouseState ms = Mouse.GetState();
        public Sprite crosshair;
        public Crosshair(
            Texture2D texture,  
            Rectangle initialFrame,
            int frameCount,
            Rectangle screenBounds)


        {
            crosshair = new Sprite(
                new Vector2(ms.X, ms.Y),
                texture,
                initialFrame,
                Vector2.Zero);
        }


        private void HandleGamepadInput(GamePadState gamePadState)
        {
           
        }

        private void imposeMovementLimits()
        {
            Vector2 location = crosshair.Location;

            crosshair.Location = location;
        }

        public void Update(GameTime gameTime)
        {
            MouseState ms = Mouse.GetState();
            crosshair.Location = new Vector2(500, ms.Y);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
                crosshair.Draw(spriteBatch);
                crosshair.TintColor = Color.Red;
        }
    }
}
