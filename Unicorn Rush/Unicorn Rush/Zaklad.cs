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
        int kwotaZakladu = 980;
        int numerJednorozca = 1;

        public Zaklad(string Imie, int Kasa) : base(Imie, Kasa)
        {

        }

        public string ZawartyZaklad()
        {
            return (base.ImieGracza() + " obstawia " + kwotaZakladu + " PLN na jednorożca numer "
                + numerJednorozca + ".");
        }
    }
}
