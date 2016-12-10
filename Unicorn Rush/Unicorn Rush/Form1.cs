﻿using System;
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

        Pula pula;

        Jednorozec J1, J2, J3, J4;
        Jednorozec[] jednorozce;

        public Form1()
        {
            InitializeComponent();

            Zbychu = new Gracz("Zbychu", 100);
            Helga = new Gracz("Helga", 100);
            Eustachy = new Gracz("Eustachy", 100);
            gracze = new Gracz[3] { Zbychu, Helga, Eustachy };

            ZZbychu = new Zaklad(Zbychu.ImieGracza(), Zbychu.KasaGracza());
            ZHelga = new Zaklad(Helga.ImieGracza(), Helga.KasaGracza());
            ZEustachy = new Zaklad(Eustachy.ImieGracza(), Eustachy.KasaGracza());
            zaklady = new Zaklad[3] { ZZbychu, ZHelga, ZEustachy };

            pula = new Pula();

            J1 = new Jednorozec(5, 1);
            J2 = new Jednorozec(105, 2);
            J3 = new Jednorozec(205, 3);
            J4 = new Jednorozec(305, 4);
            jednorozce = new Jednorozec[4] { J1, J2, J3, J4 };
            
            comboBoxGracz.SelectedIndex = 0;
            labelPula.Text = Convert.ToString(pula.StanPuli());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            J1.UstawX(pictureBoxJednorozec1.Location.X);
            pictureBoxJednorozec1.Location = new Point(J1.PodajX() + J1.PodajPredkosc(), 5);

            J2.UstawX(pictureBoxJednorozec2.Location.X);
            pictureBoxJednorozec2.Location = new Point(J2.PodajX() + J2.PodajPredkosc(), 105);

            J3.UstawX(pictureBoxJednorozec3.Location.X);
            pictureBoxJednorozec3.Location = new Point(J3.PodajX() + J3.PodajPredkosc(), 205);

            J4.UstawX(pictureBoxJednorozec4.Location.X);
            pictureBoxJednorozec4.Location = new Point(J4.PodajX() + J4.PodajPredkosc(), 305);

            if (J1.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.ustawIndeksWygrywajacegoJednorozca(0);
                J1.Wygrana();
                resetForm();
            }
            else if (J2.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.ustawIndeksWygrywajacegoJednorozca(1);
                J2.Wygrana();
                resetForm();
            }
            else if (J3.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.ustawIndeksWygrywajacegoJednorozca(2);
                J3.Wygrana();
                resetForm();
            }
            else if (J4.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.ustawIndeksWygrywajacegoJednorozca(3);
                J4.Wygrana();
                resetForm();
            }
        }

        private void resetForm()
        {
            for (int i = 0; i < jednorozce.Length; i++)
            {
                jednorozce[i].UstawX(5);
            }

            pictureBoxJednorozec1.Location = new Point(J1.PodajX(), 5);
            pictureBoxJednorozec2.Location = new Point(J2.PodajX(), 105);
            pictureBoxJednorozec3.Location = new Point(J3.PodajX(), 205);
            pictureBoxJednorozec4.Location = new Point(J4.PodajX(), 305);

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

        private void buttonStart_Click(object sender, EventArgs e)
        {
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;
            timer1.Enabled = true;
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

            gracze[comboBoxGracz.SelectedIndex].odejmijKase(
                Convert.ToInt16(numericUpDownKwotaZakladu.Value));

            pula.DodajDoPuli(Convert.ToInt16(
                zaklady[comboBoxGracz.SelectedIndex].PodajKwoteZakladu()));
            labelPula.Text = Convert.ToString(pula.StanPuli());

            try
            {
                comboBoxGracz.SelectedIndex++;
                comboBoxGracz.SelectedIndex--;
            }
            catch
            {
                comboBoxGracz.SelectedIndex--;
                comboBoxGracz.SelectedIndex++;
            }
        }

        private void comboBoxGracz_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "ma aktualnie " + gracze[comboBoxGracz.SelectedIndex].KasaGracza() + " PLN";
        }
    }
}
