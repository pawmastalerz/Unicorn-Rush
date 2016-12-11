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
        decimal kasa;

        public Gracz(string Imie, decimal Kasa)
        {
            this.imie = Imie;
            this.kasa = Kasa;
        }

        public string ImieGracza()
        {
            return this.imie;
        }

        public decimal KasaGracza()
        {
            return kasa;
        }

        public void OdejmijKase(decimal Kwota)
        {
            this.kasa -= Kwota;
        }

        public void DodajKase(decimal Kwota)
        {
            this.kasa += Kwota;
        }

        public void Resetuj()
        {
            this.kasa = 100;
        }
    }
}
