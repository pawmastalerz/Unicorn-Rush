using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn_Rush
{
    class Jednorozec
    {
        Random rnd = new Random();

        int predkosc = 0;
        int przebytaOdleglosc = 0;
        int x, y;

        public Jednorozec(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }

        public void WylosujPredkosc()
        {
            this.predkosc = rnd.Next(5, 8);
        }
    }
}
