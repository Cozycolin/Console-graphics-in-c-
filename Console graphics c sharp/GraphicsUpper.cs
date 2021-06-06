using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Graphics.Handlers;


namespace Graphics
{
    public class Screen
    {
        int width;
        int height;
        Frame[] swapBuffer;
        byte currentBuffer = 0;
        byte currentBufferOpposite = 1;
        public FrameManipulator frameManipulator;
        public Screen()
        {
            swapBuffer = new Frame[2];
            frameManipulator = new FrameManipulator();
        }
        public void swapBuffers()
        {
            currentBuffer += 0b1;
            currentBufferOpposite += 0b1;
            CheckBufferNumbers();
            frameManipulator.SetActiveFrame(swapBuffer[currentBufferOpposite]);
        }
        public void displayFrame()
        {
            Frame frame = swapBuffer[currentBuffer];
            for (int x = 0; x < frame.width; x++)
            {
                for (int y = 0; y < frame.height; y++)
                {
                    if (frame.getLightMap()[x,y] == true)
                    {
                        Console.Write(frame.getCharMap()[x, y]);
                    }
                }
            }
        }
        void CheckBufferNumbers()
        {
            if (currentBuffer > 1)
            {
                currentBuffer = 0;
            }
            if (currentBufferOpposite > 1)
            {
                currentBufferOpposite = 0;
            }
        }
    }
}
