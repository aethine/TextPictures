using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextDrawer
{
    class Program
    {
        List<Picture> memory = new List<Picture>();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter command or help to help");

        }
    }
    class Picture
    {
        string name;
        char[,] image;
        public Picture(string name, int xsize, int ysize) { this.name = name; image = new char[xsize, ysize]; }
    }
}
