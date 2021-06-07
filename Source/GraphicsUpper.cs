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
            //setup height and the window
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.BufferWidth = width;
            swapBuffer = new Frame[2] { new Frame(this.width, this.height), new Frame(this.width, this.height) };
        }
        void swapBuffers()
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
            char[,] charmap = frame.getCharMap();
            bool[,] visibilitymap = frame.getLightMap();
            //step1 move the frame to a more displayable format
            string charsToDisplay = "";
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (visibilitymap[x, y] == true)
                    {
                        charsToDisplay += charmap[x, y];
                    }
                    else
                    {
                        charsToDisplay += ' ';
                    }
                }
                charsToDisplay += '\n';
            }

            //display the formatted frame
            
            for (int i = 0; i < width; i++)
            {
                Console.Write('-');
            }
            Console.Write('\n');
            Console.WriteLine(charsToDisplay);
            Console.Write('\n');
            for (int i = 0; i < width; i++)
            {
                Console.Write('-');
            }
            //flips buffer
            swapBuffer[currentBuffer].resetFrame();
            swapBuffer[currentBufferOpposite] = frameManipulator.RetrurnManipulatedFrame();
            swapBuffers();
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
