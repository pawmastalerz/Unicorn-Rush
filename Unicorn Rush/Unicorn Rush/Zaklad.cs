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
        int kwotaZakladu = 2;
        int numerJednorozca;
        bool zaglosowano = false;

        public Zaklad(string Imie, int Kasa) : base(Imie, Kasa)
        {

        }

        public void UstawNumerJednorozca(int NumerJednorozca)
        {
            this.numerJednorozca = NumerJednorozca;
        }

        public void UstawKwoteZakladu(int KwotaZakladu)
        {
            this.kwotaZakladu = KwotaZakladu;
        }

        public void Zaglosowano()
        {
            this.zaglosowano = true;
        }

        public void ResetujZaglosowanie()
        {
            this.zaglosowano = false;
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
