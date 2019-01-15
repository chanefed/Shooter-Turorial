using Microsoft.Xna.Framework.Graphics;

namespace Shooter
{
    //A Collection of properties for the background layer that will be set in the Level class.
    //The property names should be obvious as to what they are doing
    //No empty constructor as VS autogenerates one
    public class BackgroundLayer
    {
        public Texture2D Texture { get; set; }

        public float ScrollingSpeed { get; set; }

        public float OffsetX { get; set; }
        public float OffsetY { get; set; }
    }
}
