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
            public int x;
            public int y;
            public Coor(int ix = 0, int iy = 0)
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
