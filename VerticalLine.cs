using Snake_oop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_oop
{
    class VerticalLine
    {
       

        List<Point> pList;

        public VerticalLine(int yUp, int yDowp, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDowp; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }


        }
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
