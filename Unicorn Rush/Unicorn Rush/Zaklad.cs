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

        public Zaklad(string Imie, int Kasa) : base(Imie, Kasa)
        {

        }

        public string ZawartyZaklad()
        {
            return (base.ImieGracza() + " obstawia " + kwotaZakladu + " PLN na jednorożca numer "
                + numerJednorozca + ".");
        }

        public void UstawNumerJednorozca(int NumerJednorozca)
        {
            this.numerJednorozca = NumerJednorozca;
        }

        public void UstawKwoteZakladu(int KwotaZakladu)
        {
            this.kwotaZakladu = KwotaZakladu;
        }
    }
}
