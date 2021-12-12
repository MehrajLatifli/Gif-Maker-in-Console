using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Gif_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
    


            using (MagickImageCollection collection = new MagickImageCollection())
            {

                collection.Add("../../Images/b1.png");
                collection[0].AnimationDelay = 50;

                collection.Add("../../Images/b2.png");
                collection[1].AnimationDelay = 50;

                collection.Add("../../Images/b3.png");
                collection[2].AnimationDelay = 50;

                collection.Add("../../Images/b4.png");
                collection[3].AnimationDelay = 50;

                collection.Add("../../Images/b4.png");
                collection[4].AnimationDelay = 50;

                collection.Add("../../Images/b3.png");
                collection[5].AnimationDelay = 50;

                collection.Add("../../Images/b2.png");
                collection[6].AnimationDelay = 50;

                collection.Add("../../Images/b1.png");
                collection[7].AnimationDelay = 50;


                // Optionally reduce colors
                QuantizeSettings settings = new QuantizeSettings();
                settings.Colors = 256;
                collection.Quantize(settings);

                // Optionally optimize the images (images should have the same size).
                collection.Optimize();

                // Save gif
                collection.Write("../../Images/Robot dance.gif");
            }

            Console.ReadKey();
        }

    
    }
}
