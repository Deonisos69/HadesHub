using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadesHub
{
    internal class boardGrid
    {
        public int xSize;
        public int ySize;
        public Widget[] widgets;

        public boardGrid(int xSize, int ySize, Widget[] widgets)
        {
            this.xSize = xSize;
            this.ySize = ySize;
            this.widgets = widgets;
        }
    }
    
}
