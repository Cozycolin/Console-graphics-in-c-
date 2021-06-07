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
            public readonly int width;
            public readonly int height;
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
            public void setChar(Coor coor,char filler)
            {
                charmap[coor.x, coor.y] = filler;
            }
            public void setVisibility(Coor coor, bool visibility)
            {
                lightmap[coor.x, coor.y] = visibility;
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
            public void fillchars(Coor startCoor,Coor endCoor, char filler)
            {
                for (int x = startCoor.x; x < endCoor.x; x++)
                {
                    for (int y = startCoor.y; y < endCoor.y; y++)
                    {
                        activeFrame.setChar(new Coor(x,y),filler);
                    }
                }
            }
            public void fillVisibility(Coor startCoor, Coor endCoor, bool visibility)
            {
                for (int x = startCoor.x; x < endCoor.x; x++)
                {
                    for (int y = startCoor.y; y < endCoor.y; y++)
                    {
                        activeFrame.setVisibility(new Coor(x, y), visibility);
                    }
                }
            }
            public void setChar(int x, int y, char filler)
            {
                activeFrame.setChar(new Coor(x, y), filler);
            }
            public void setVisibility(int x, int y, bool visibility)
            {
                activeFrame.setVisibility(new Coor(x, y), visibility);
            }
        }
    }
}
