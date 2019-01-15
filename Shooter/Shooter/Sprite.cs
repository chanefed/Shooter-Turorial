using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    public abstract class Sprite 
    {
        //Begin here. This Sprite class will handle every sprite in the game.
        //Sprites are passed to it and the Draw method is overridden

        //create a place to hold the texture
        public Texture2D texture;

        //create variables to store the position and size of the image passed in
        protected Vector2 position;
        protected int width, height;

        //create properties to manipulate the position of the sprite
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        //create a Rectangle and set it to the width and height that will be passed in to surround our image
        //It's easier to move a rectangle around that the actual image.
        public Rectangle Rect
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, width, height);
            }
        }

        //Now create the Sprite constructor. You CAN create the empty constructor as well, but VS already does that
        //so I generally skip it.
        //The sprite will need a position and it's height and width set
        public Sprite(Vector2 position, int width, int height)
        {
            this.position = position;
            this.width = width;
            this.height = height;
        }

        //set up a call to Update and Draw here. You'll also see it in Main by default, but
        //I'm going to use those to override and these methods .
        public abstract void Update(GameTime gameTime);

        public abstract void Draw(SpriteBatch spriteBatch);

        //Move to Player from here
    }
}
