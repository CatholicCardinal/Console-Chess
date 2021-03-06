using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Square
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public static Square none = new Square(-1, -1);
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Square(string e)
        {
            if (e.Length == 2 && e[0] >= 'a' && e[0] <= 'h' && e[1] >= '1' && e[1] <= '8')
            {
                x = e[0] - 'a';
                y = e[1] - '1';
            }
            //else 
                //this = none;
        }

        public bool OnBoard()
        {
            return x >= 0 && x < 8 && y >= 0 && y < 8;
        }

        public static bool operator == (Square a, Square b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Square a, Square b)
        {
            return a.x != b.x || a.y != b.y;
        }

        public static IEnumerable<Square> YieldSquare()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    yield return new Square(x, y);
                }
            }
        }

        public string Name { get { return ((char)('a' + x)).ToString() + (y + 1).ToString(); } }
    }
}
