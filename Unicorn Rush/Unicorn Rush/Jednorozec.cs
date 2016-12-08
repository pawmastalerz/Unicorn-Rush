using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicorn_Rush
{
    class Jednorozec
    {
        static Random rnd = new Random();

        int predkosc = 0;
        int x;
        int numerJednorozca;

        public Jednorozec(int X, int NumerJednorozca)
        {
            this.x = X;
            this.numerJednorozca = NumerJednorozca;
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

        public bool CzyJuzWygral()
        {
            if (this.x >= 615)
            {
                return true;
            }
            else return false;
        }

        public void Wygrana()
        {
            MessageBox.Show("Wygrał jednorożec numer " + this.numerJednorozca + "!");
        }
    }
}
