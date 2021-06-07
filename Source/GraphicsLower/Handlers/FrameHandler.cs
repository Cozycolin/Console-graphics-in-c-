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
                DefaultVisibility = true;
                ClearChar = '=';
                resetFrame();
            }
            public void resetFrame()
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
                if (CheckIfInBounds(coor)) { charmap[coor.x, coor.y] = filler; }
            }
            public void setVisibility(Coor coor, bool visibility)
            {
                if (CheckIfInBounds(coor)) { lightmap[coor.x, coor.y] = visibility; }
            }
            public bool CheckIfInBounds(Coor coor)
            {
                if(coor.x > 0 && coor.x < width && coor.y > 0 && coor.y < height)
                {
                    return true;
                }
                else 
                { 
                    return false;
                }
            }
        }
        public class FrameManipulator
        {
            Frame activeFrame;
            public Frame RetrurnManipulatedFrame()
            {
                return activeFrame;
            }

            public void SetActiveFrame(Frame frame)
            {
                this.activeFrame = frame;
            }
            //All ways to manipulate a frames content:
            public void fillchars(Coor startCoor,Coor endCoor, char filler)
            {
                for (UInt32 x = startCoor.x; x < endCoor.x; x++)
                {
                    for (UInt32 y = startCoor.y; y < endCoor.y; y++)
                    {
                        activeFrame.setChar(new Coor(x,y),filler);
                    }
                }
            }
            public void fillVisibility(Coor startCoor, Coor endCoor, bool visibility)
            {
                for (UInt32 x = startCoor.x; x < endCoor.x; x++)
                {
                    for (UInt32 y = startCoor.y; y < endCoor.y; y++)
                    {
                        activeFrame.setVisibility(new Coor(x, y), visibility);
                    }
                }
            }
            public void setChar(Coor coor, char filler)
            {
                activeFrame.setChar(coor, filler);
            }
            public void setVisibility(Coor coor, bool visibility)
            {
                activeFrame.setVisibility(coor, visibility);
            }
        }
    }
}
