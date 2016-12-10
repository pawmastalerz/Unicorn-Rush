using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn_Rush
{
    class Gracz
    {
        string imie;
        int kasa;

        public Gracz(string Imie, int Kasa)
        {
            this.imie = Imie;
            this.kasa = Kasa;
        }

        public string ImieGracza()
        {
            return this.imie;
        }

        public int KasaGracza()
        {
            return kasa;
        }

        public void odejmijKase(int Kwota)
        {
            this.kasa -= Kwota;
        }
    }
}
