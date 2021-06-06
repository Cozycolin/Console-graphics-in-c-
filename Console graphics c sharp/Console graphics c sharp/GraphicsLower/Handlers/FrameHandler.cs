using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    namespace Handlers
    {
        class Frame
        {
            public int width;
            public int height;
            public char[,] charmap;
            public byte[,] lightmap;
            public char clearChar = ' ';

            Frame(int width, int height)
            {
                this.width = width;
                this.height = height;
                charmap = new char[width,height];
                lightmap = new byte[width, height];
            }
            void resetFrame()
            {
                for(int x = 0;x < width;x++)
                {
                    for(int y = 0; y < height; y++)
                    {
                        charmap[x, y] = clearChar;
                    }
                }
            }
            
        }
    }
}
