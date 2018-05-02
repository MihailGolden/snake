using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int width;
        private int heigth;
        private char sym;

        public FoodCreator(int width, int heigth, char sym)
        {
            this.width = width;
            this.heigth = heigth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            Random rand = new Random();
            int x = rand.Next(width-2) + 1;
            int y = rand.Next(heigth-2) + 1;
            Point p = new Point(x, y, sym);
            return p;
        }
    }
}
