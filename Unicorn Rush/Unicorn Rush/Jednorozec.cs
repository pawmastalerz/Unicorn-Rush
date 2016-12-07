using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn_Rush
{
    class Jednorozec
    {
        static Random rnd = new Random();

        int predkosc = 0;
        int x;

        public Jednorozec(int X)
        {
            this.x = X;
        }

        public void WylosujPredkosc()
        {
            this.predkosc = rnd.Next( 3, 15 );
        }
        
        public int PodajPredkosc()
        {
            WylosujPredkosc();
            return this.predkosc;
        }

        public int PodajX()
        {
            return this.x;
        }
        
        public void UstawX(int X)
        {
            this.x = X;
        }
    }
}
