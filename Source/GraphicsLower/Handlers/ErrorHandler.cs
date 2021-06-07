using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    namespace Handlers
    {
        namespace errorHandler
        {
            public class GraphicsErrorHandler
            {
                public void RaiseError(string ErrorMessage)
                {
                    Console.Clear();
                    Console.WriteLine(ErrorMessage);
                    while (true)
                    {
                        
                    }
                }
            }
        }
    }
}
