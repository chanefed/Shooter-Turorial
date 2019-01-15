using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shooter
{
    public class Player : Sprite
    {
        //create a property to get and set the life count of the palyer
        public int Lives { get; set; }

        //set the initial speed that the ship will be moving at
        public float speed = 500;
        public Vector2 velocity;

        //create a constructor of the Player class. It will use the base class
        //to set the position of the texture
        public Player(Main game) : base(Vector2.Zero, 300, 100)
        {
            texture = game.Content.Load<Texture2D>("_player/player");

            Lives = 5;
        }

        //Override the Update and Draw methods in Sprite to move the player based on a key press
        public override void Update(GameTime gameTime)
        {
            KeyboardState kbState = Keyboard.GetState();

            if (kbState.IsKeyDown(Keys.Up))
            {
                velocity.Y = -speed;
            }
            else if (kbState.IsKeyDown(Keys.Down))
            {
                velocity.Y = speed;
            }
            else
                velocity.Y = 0;

            if (kbState.IsKeyDown(Keys.Left))
            {
                velocity.X = -speed;
            }
            else if (kbState.IsKeyDown(Keys.Right))
            {
                velocity.X = speed;
            }
            else
                velocity.X = 0;

            float elapsedSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;

            position += velocity * elapsedSeconds;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Rect, Color.White);
        }
    }
}
