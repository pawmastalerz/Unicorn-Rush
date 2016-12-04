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
            comboBoxGracz.SelectedIndex = 0;

            Zbychu = new Gracz("Zbychu", 300);
            Helga = new Gracz("Helga", 200);
            Eustachy = new Gracz("Eustachy", 100);

            gracze = new Gracz[3] { Zbychu, Helga, Eustachy };

            ZZbychu = new Zaklad(Zbychu.ImieGracza(), Zbychu.KasaGracza());
            ZHelga = new Zaklad(Helga.ImieGracza(), Helga.KasaGracza());
            ZEustachy = new Zaklad(Eustachy.ImieGracza(), Eustachy.KasaGracza());

            zaklady = new Zaklad[3] { ZZbychu, ZHelga, ZEustachy };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;
            MessageBox.Show("Patatajajo xD" , "No, super.");

            //labelEustachyZaklad.Text = gracze[2].ZawartyZaklad();
        }

        private void buttonPodpiszZaklad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zakład przyjęty.", "Zawarto zakład!");
        }

        private void comboBoxGracz_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "ma aktualnie PLN";
        }
    }
}
