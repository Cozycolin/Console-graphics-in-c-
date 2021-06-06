using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Graphics;
namespace Console_graphics_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            screen.swapBuffers();
            screen.displayFrame();
        }
    }
}
