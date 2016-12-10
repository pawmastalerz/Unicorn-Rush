using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicorn_Rush
{
    class Zaklad : Gracz
    {
        int kwotaZakladu = 0;
        int numerJednorozca = 4;
        bool zaglosowano = false;

        public Zaklad(string Imie, int Kasa) : base(Imie, Kasa)
        {

        }

        public void UstawNumerJednorozca(int NumerJednorozca)
        {
            this.numerJednorozca = NumerJednorozca;
        }

        public int PodajNumerJednorozca()
        {
            return this.numerJednorozca;
        }

        public void UstawKwoteZakladu(int KwotaZakladu)
        {
            this.kwotaZakladu = KwotaZakladu;
        }

        public int PodajKwoteZakladu()
        {
            return this.kwotaZakladu;
        }

        public void Zaglosowano()
        {
            this.zaglosowano = true;
        }

        public void ResetujZaglosowanie()
        {
            this.zaglosowano = false;
            this.kwotaZakladu = 0;
            this.numerJednorozca = 4;
        }

        public bool CzyZaglosowano()
        {
            return this.zaglosowano;
        }

        public string ZawartyZaklad()
        {
            return (base.ImieGracza() + " obstawia " + kwotaZakladu + " PLN na jednorożca numer "
                + numerJednorozca + ".");
        }
    }
}
