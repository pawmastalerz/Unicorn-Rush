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
        int indeksWygrywajacegoJednorozca = 4;
        public bool[] indeksGraczaWygrywajacego = new bool[3];

        public int PokazIndeksWygrywajacegoJednorozca()
        {
            return indeksWygrywajacegoJednorozca;
        }

        public void UstawIndeksWygrywajacegoJednorozca(int Numer)
        {
            this.indeksWygrywajacegoJednorozca = Numer;
        }

        public void UstawSzczesliwegoGracza(int Indeks)
        {
            this.indeksGraczaWygrywajacego[Indeks] = true;
        }

        public bool PokazSzczescieGracza(int Indeks)
        {
            return indeksGraczaWygrywajacego[Indeks];
        }

        public int StanPuli()
        {
            return kasa;
        }

        public void DodajDoPuli(int Kwota)
        {
            this.kasa += Kwota;
        }

        public void ResetujPule()
        {
            this.kasa = 5;
            this.indeksWygrywajacegoJednorozca = 4;
            for (int i = 0; i < indeksGraczaWygrywajacego.Length; i++)
            {
                indeksGraczaWygrywajacego[i] = false;
            }
        }
    }
}
