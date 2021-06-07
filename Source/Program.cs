using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphics;
using Graphics.Handlers.errorHandler;
namespace Console_graphics_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("program has started");
            Screen screen = new Screen();
            screen.swapBuffers();
            screen.displayFrame();
            Console.ReadKey();
        }
    }
}
