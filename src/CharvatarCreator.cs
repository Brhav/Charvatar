using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using SixLabors.Primitives;

namespace Charvatar
{
    public static class CharvatarCreator
    {
        public static Image<Rgba32> CreateCharvatar(string characters, int width = 100, int height = 100, string fontFamilyName = "Arial", float fontEmSize = 70, Rgba32? textColor = null)
        {
            var image = new Image<Rgba32>(width, height);
            var backgroundColor = ColorHelper.GenerateRandomColor(Rgba32.White);
            image.Mutate(x => x.BackgroundColor(backgroundColor));
            image.Mutate(x => x.Brightness((float)0.7));
            image.Mutate(x => x.Contrast((float)1.8));
            var textGraphicsOptions = new TextGraphicsOptions(true)
            {
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
            var fontFamily = SystemFonts.Find(fontFamilyName);
            var font = new Font(fontFamily, fontEmSize);
            var center = new PointF(image.Width / 2, image.Height / 2);
            image.Mutate(x => x.DrawText(textGraphicsOptions, characters, font, textColor ?? Rgba32.White, center));
            return image;
        }
    }
}
