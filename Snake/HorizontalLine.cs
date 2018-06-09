using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int _xLeft, int _xRight, int _y, char _sym)
        {
            pList = new List<Point>();

            for (int x = _xLeft; x <= _xRight; x++)
            {
                pList.Add(new Point(x, _y, _sym));
                //Point p = new Point(x, y, sym);
                //pList.Add(p);
            }
        }
    }
}
