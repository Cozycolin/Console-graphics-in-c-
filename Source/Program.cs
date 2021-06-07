using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphics;
using Graphics.Handlers;
using Graphics.Handlers.errorHandler;
namespace Console_graphics_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program has started");
            Screen screen = new Screen();
            while (true)
            {
                screen.frameManipulator.fillchars(new Coor(1, 1), new Coor(4, 3), '0');
                screen.displayFrame();
            }
        }
    }
}
