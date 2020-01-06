using System.IO;
using SixLabors.ImageSharp;

namespace Charvatar
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 65; i <= 90; i++)
            {
                using (var fileStream = File.Create($"{i}.png"))
                {
                    var image = CharvatarCreator.CreateCharvatar(((char)i).ToString());
                    image.SaveAsPng(fileStream);
                }
            }
        }
    }
}
