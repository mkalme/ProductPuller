using System;
using System.Drawing;
using ProductPullerAutomatic;

namespace ConsoleDemo {
    internal class Program {
        static void Main(string[] args) {
            Bitmap bmp = new Bitmap(Image.FromFile("D:\\Screenshot.png"));

            ImageMatcher matcher = new ImageMatcher();

            Point[] points = matcher.FindMatches(bmp);

            Console.WriteLine(points.Length);

            foreach (Point p in points) {
                Console.WriteLine(p);
            }

            Console.ReadLine();
        }
    }
}