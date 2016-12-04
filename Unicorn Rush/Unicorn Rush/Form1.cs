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
        Gracz Zbychu; 
        Gracz Helga;
        Gracz Eustachy;
        Gracz[] gracze;
        
        public Form1()
        {
            InitializeComponent();
            comboBoxGracz.SelectedIndex = 0;

            Zbychu = new Gracz("Zbychu", 300);
            Helga = new Gracz("Helga", 200);
            Eustachy = new Gracz("Eustachy", 100);

            gracze = new Gracz[3] { Zbychu, Helga, Eustachy };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;
            MessageBox.Show("Patatajajo xD" , "No, super.");

            labelZbychuZaklad.Text = gracze[0].ZawartyZaklad();
            labelHelgaZaklad.Text = gracze[1].ZawartyZaklad();
            labelEustachyZaklad.Text = gracze[2].ZawartyZaklad();
        }

        private void buttonPodpiszZaklad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zakład przyjęty.", "Zawarto zakład!");
        }

        private void comboBoxGracz_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
