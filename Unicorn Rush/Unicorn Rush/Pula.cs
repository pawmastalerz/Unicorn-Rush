using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn_Rush
{
    class Pula
    {
        decimal kasa = 5;
        int indeksWygrywajacegoJednorozca = 4;
        public bool[] indeksGraczaWygrywajacego = new bool[3];
        decimal kwotaKumulacji = 0;

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

        public decimal StanPuli()
        {
            return kasa;
        }

        public void DodajDoPuli(decimal Kwota)
        {
            this.kasa += Kwota;
        }

        public void Kumulacja(decimal Kwota)
        {
            this.kwotaKumulacji = Kwota;
        }

        public decimal KwotaKumulacji()
        {
            return this.kwotaKumulacji;
        }

        public void ResetujKumulacje()
        {
            this.kwotaKumulacji = 0;
        }

        public void ResetujPule()
        {
            this.kasa = kwotaKumulacji + 5;
            this.indeksWygrywajacegoJednorozca = 4;
            for (int i = 0; i < indeksGraczaWygrywajacego.Length; i++)
            {
                indeksGraczaWygrywajacego[i] = false;
            }
        }
    }
}
