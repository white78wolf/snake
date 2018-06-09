using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int _yUp, int _yDown, int _x, char _sym)
        {
            pList = new List<Point>();

            for (int y = _yUp; y <= _yDown; y++)
            {
                pList.Add(new Point(_x, y, _sym));
                //Point p = new Point(x, y, sym);
                //pList.Add(p);
            }
        }
    }
}
