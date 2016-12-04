using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicorn_Rush
{
    public partial class Form1 : Form
    {
        Gracz Zbychu, Helga, Eustachy;
        Gracz[] gracze;

        Zaklad ZZbychu, ZHelga, ZEustachy;
        Zaklad[] zaklady;

        public Form1()
        {
            InitializeComponent();

            Zbychu = new Gracz("Zbychu", 300);
            Helga = new Gracz("Helga", 200);
            Eustachy = new Gracz("Eustachy", 100);

            gracze = new Gracz[3] { Zbychu, Helga, Eustachy };

            ZZbychu = new Zaklad(Zbychu.ImieGracza(), Zbychu.KasaGracza());
            ZHelga = new Zaklad(Helga.ImieGracza(), Helga.KasaGracza());
            ZEustachy = new Zaklad(Eustachy.ImieGracza(), Eustachy.KasaGracza());

            zaklady = new Zaklad[3] { ZZbychu, ZHelga, ZEustachy };

            comboBoxGracz.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;

            MessageBox.Show("Patatajajo xD" , "No, super.");

            buttonPodpiszZaklad.Enabled = true;
            buttonStart.Enabled = true;

            for (int i = 0; i < zaklady.Length; i++)
            {
                zaklady[i].ResetujZaglosowanie();
            }

            labelZbychuZaklad.Text = "Czekam na zakład Zbycha...";
            labelHelgaZaklad.Text = "Czekam na zakład Helgi...";
            labelEustachyZaklad.Text = "Czekam na zaklad Eustachego...";
        }

        private void buttonPodpiszZaklad_Click(object sender, EventArgs e)
        {
            zaklady[comboBoxGracz.SelectedIndex].UstawNumerJednorozca(
                Convert.ToInt16(numericUpDownJednorozecNumer.Value));
            zaklady[comboBoxGracz.SelectedIndex].UstawKwoteZakladu(
                Convert.ToInt16(numericUpDownKwotaZakladu.Value));

            if ((comboBoxGracz.SelectedIndex == 0) && (zaklady[0].CzyZaglosowano() == false))
            {
                labelZbychuZaklad.Text = zaklady[0].ZawartyZaklad();
                zaklady[0].Zaglosowano();
            }

            else if ((comboBoxGracz.SelectedIndex == 1) && (zaklady[1].CzyZaglosowano() == false))
            {
                labelHelgaZaklad.Text = zaklady[1].ZawartyZaklad();
                zaklady[1].Zaglosowano();
            }
            else if ((comboBoxGracz.SelectedIndex == 2) && (zaklady[2].CzyZaglosowano() == false))
            {
                labelEustachyZaklad.Text = zaklady[2].ZawartyZaklad();
                zaklady[2].Zaglosowano();
            }

            //MessageBox.Show(zaklady[comboBoxGracz.SelectedIndex].ZawartyZaklad(), "Zawarto zakład!");
        }

        private void comboBoxGracz_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "ma aktualnie " + gracze[comboBoxGracz.SelectedIndex].KasaGracza() + " PLN";
        }
    }
}
