using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        private List<Point> pList;
        public VerticalLine(int yLow, int yHi, int x, char sym)
        {
            pList = new List<Point>();
            for (int i = yLow; i <= yHi; i++)
            {
                Point temp = new Point(x, i, sym);
                pList.Add(temp);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
