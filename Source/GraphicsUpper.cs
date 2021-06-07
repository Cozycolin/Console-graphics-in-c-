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
        public readonly int width;
        public readonly int height;
        Frame[] swapBuffer;
        byte currentBuffer = 0;
        byte currentBufferOpposite = 1;
        public FrameManipulator frameManipulator;
        public Handlers.errorHandler.GraphicsErrorHandler errorHandler;
        public Screen()
        {
            frameManipulator = new FrameManipulator();
            errorHandler = new Handlers.errorHandler.GraphicsErrorHandler();
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            swapBuffer = new Frame[2] { new Frame(this.width, this.height), new Frame(this.width, this.height) };
            //acknowledgement
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
            Console.Clear();
            if(frame.width != width || frame.height != height)
            {
                errorHandler.RaiseError("frame dimensions do not meet graphics dimensions, "
                    + frame.width +' ' + width + ',' + frame.height + ' ' + height);
            }
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
