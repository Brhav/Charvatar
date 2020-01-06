using System;
using SixLabors.ImageSharp.PixelFormats;

namespace Charvatar
{
    public static class ColorHelper
    {
        /// <summary>
        /// <see href="https://stackoverflow.com/questions/43044/algorithm-to-randomly-generate-an-aesthetically-pleasing-color-palette" />
        /// </summary>
        public static Rgba32 GenerateRandomColor(Rgba32? mixColor = null)
        {
            var random = new Random((int)DateTime.UtcNow.Ticks);
            var red = random.Next(0, 256);
            var green = random.Next(0, 256);
            var blue = random.Next(0, 256);
            if (mixColor != null)
            {
                red = (red + mixColor.Value.R) / 2;
                green = (green + mixColor.Value.G) / 2;
                blue = (blue + mixColor.Value.B) / 2;
            }
            return new Rgba32((byte)red, (byte)green, (byte)blue);
        }
    }
}
