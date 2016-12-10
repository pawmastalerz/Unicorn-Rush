using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn_Rush
{
    class Pula
    {
        int kasa = 5;
        int indeksWygrywajacegoJednorozca = 0;

        public void ustawIndeksWygrywajacegoJednorozca(int Numer)
        {
            this.indeksWygrywajacegoJednorozca = Numer;
        }

        public int StanPuli()
        {
            return kasa;
        }

        public void DodajDoPuli(int Kwota)
        {
            this.kasa += Kwota;
        }
    }
}
