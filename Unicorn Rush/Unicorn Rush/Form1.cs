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

        Jednorozec J1, J2, J3, J4;
        Jednorozec[] jednorozce;

        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();

            Zbychu = new Gracz("Zbychu", 300);
            Helga = new Gracz("Helga", 200);
            Eustachy = new Gracz("Eustachy", 100);
            gracze = new Gracz[3] { Zbychu, Helga, Eustachy };

            ZZbychu = new Zaklad(Zbychu.ImieGracza(), Zbychu.KasaGracza());
            ZHelga = new Zaklad(Helga.ImieGracza(), Helga.KasaGracza());
            ZEustachy = new Zaklad(Eustachy.ImieGracza(), Eustachy.KasaGracza());
            zaklady = new Zaklad[3] { ZZbychu, ZHelga, ZEustachy };

            J1 = new Jednorozec(17, 16);
            J2 = new Jednorozec(17, 116);
            J3 = new Jednorozec(17, 216);
            J4 = new Jednorozec(17, 316);
            jednorozce = new Jednorozec[4] { J1, J2, J3, J4 };

            comboBoxGracz.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = pictureBoxJednorozec1.Location.X;
            int y = pictureBoxJednorozec1.Location.Y;

            pictureBoxJednorozec1.Location = new Point(x + 15, y);

            if (x >= 400)
            {
                timer1.Stop();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;
            timer1.Enabled = true;
            

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
            if ((comboBoxGracz.SelectedIndex == 0) && (zaklady[0].CzyZaglosowano() == true))
            {
                MessageBox.Show("Zbychu już obstawił!", "Niestety...");
            }
            else if ((comboBoxGracz.SelectedIndex == 1) && (zaklady[1].CzyZaglosowano() == true))
            {
                MessageBox.Show("Helga już obstawiła!", "Niestety...");
            }
            else if ((comboBoxGracz.SelectedIndex == 2) && (zaklady[2].CzyZaglosowano() == true))
            {
                MessageBox.Show("Eustachy już obstawił!", "Niestety...");
            }

            if ((comboBoxGracz.SelectedIndex == 0) && (zaklady[0].CzyZaglosowano() == false))
            {
                ustawZaklad();
                labelZbychuZaklad.Text = zaklady[0].ZawartyZaklad();
                zaklady[0].Zaglosowano();
            }
            else if ((comboBoxGracz.SelectedIndex == 1) && (zaklady[1].CzyZaglosowano() == false))
            {
                ustawZaklad();
                labelHelgaZaklad.Text = zaklady[1].ZawartyZaklad();
                zaklady[1].Zaglosowano();
            }
            else if ((comboBoxGracz.SelectedIndex == 2) && (zaklady[2].CzyZaglosowano() == false))
            {
                ustawZaklad();
                labelEustachyZaklad.Text = zaklady[2].ZawartyZaklad();
                zaklady[2].Zaglosowano();
            }
        }

        private void ustawZaklad()
        {
            zaklady[comboBoxGracz.SelectedIndex].UstawNumerJednorozca(
                Convert.ToInt16(numericUpDownJednorozecNumer.Value));
            zaklady[comboBoxGracz.SelectedIndex].UstawKwoteZakladu(
                Convert.ToInt16(numericUpDownKwotaZakladu.Value));
        }

        private void comboBoxGracz_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "ma aktualnie " + gracze[comboBoxGracz.SelectedIndex].KasaGracza() + " PLN";
        }
    }
}
