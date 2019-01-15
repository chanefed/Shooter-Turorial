using Microsoft.Xna.Framework;

namespace Shooter
{
    public class Camera
    {
        //a variable to hold the camera position
        private Vector2 position;

        //Create properties for the position of the camera for the Level to set
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        //create an instance of the Level class here
        private Level level;

        //create a property for the movement speed of the layer
        public float ScrollingSpeed { get; set; }

        //create a constructor of this class with two values
        //again, VS already creates the empty constructor
        public Camera(Level level)
        {
            this.level = level;
            ScrollingSpeed = 100;
        }

        //update the camera movement per frame after it has confirmed the layer's previous position
        public void Update(GameTime gameTime)
        {
            float elapsedSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float previousPosX = position.X; //previous X position of the layer

            position.X -= ScrollingSpeed * elapsedSeconds; //set the new position of the layer

            for (int i = 0; i < level.backgroundLayers.Length; i++) //for every item in the backgroundLayer array in Level
            {
                //create an instance of it
                BackgroundLayer layer = level.backgroundLayers[i];
                //access the ScrollSpeed property of BackgroundLayer and set OffsetX property
                level.backgroundLayers[i].OffsetX -= layer.Texture.Width;

                if (level.backgroundLayers[i].OffsetX < layer.Texture.Width)
                {
                    level.backgroundLayers[i].OffsetX = 0;
                }

            }
        }

        public Matrix GetMatrix()
        {
            return Matrix.CreateTranslation(new Vector3(position, 0));
        }
    }
}
