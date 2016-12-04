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
        Gracz Eustachy = new Gracz("Eustachy", 300);

        public Form1()
        {
            InitializeComponent();
            comboBoxGracz.SelectedIndex = 0;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;
            MessageBox.Show("Patatajajo xD", "No, super.");
            labelEustachyZaklad.Text = Eustachy.ZawartyZaklad();
        }

        private void buttonPodpiszZaklad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zakład przyjęty.", "Zawarto zakład!");
        }
    }
}
