using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics
{
    namespace Handlers
    {
        public struct Coor
        {
            public UInt32 x;
            public UInt32 y;
            public Coor(UInt32 ix = 0, UInt32 iy = 0)
            {
                x = ix;
                y = iy;
            }
            public override string ToString()
            {
                return x.ToString() + ' ' + y.ToString();
            }
            
        }
    }
}
