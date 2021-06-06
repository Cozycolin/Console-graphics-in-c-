using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    namespace Handlers
    {
        public struct Frame
        {
            public int width;
            public int height;
            char[,] charmap;
            bool[,] lightmap;
            public char ClearChar;
            public bool DefaultVisibility;

            public Frame(int width, int height)
            {
                this.width = width;
                this.height = height;
                charmap = new char[width, height];
                lightmap = new bool[width, height];
                DefaultVisibility = false;
                ClearChar = '0';
                resetFrame();
            }
            void resetFrame()
            {
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        charmap[x, y] = ClearChar;
                        lightmap[x, y] = DefaultVisibility;
                    }
                }
            }
            public char[,] getCharMap()
            {
                return charmap;
            }
            public bool[,] getLightMap()
            {
                return lightmap;
            }
        }
        public class FrameManipulator
        {
            private Frame activeFrame;
            public Frame RetrurnManipulatedFrame()
            {
                return activeFrame;
            }

            public void SetActiveFrame(Frame frame)
            {
                activeFrame = frame;
            }
            //All ways to manipulate a frames content:
            public void fill(int xstart, int ystart, int xend, int yend, char filler)
            {
                
            }
            public void setChar(int x, int y, char filler)
            {

            }
        }
    }
}
