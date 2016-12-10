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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public void DodajDoRaportu(string Dane)
        {
            this.textBoxRaport.Text += (Dane + "\r\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxRaport.Text = "";
            this.Close();
        }
    }
}
