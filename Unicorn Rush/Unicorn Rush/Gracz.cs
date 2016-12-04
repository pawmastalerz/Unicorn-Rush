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
        int kwotaAktualnegoZakladu = 980;
        int numerWybranegoJednorozca = 0;

        public Gracz(string Imie, int Kasa)
        {
            this.imie = Imie;
            this.kasa = Kasa;
        }

        public string ZawartyZaklad()
        {
            return (this.imie + " obstawia " + kwotaAktualnegoZakladu + " PLN na jednorożca numer "
                + numerWybranegoJednorozca);
        }
    }
}
