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

        Pula pula;

        Jednorozec J1, J2, J3, J4;
        Jednorozec[] jednorozce;

        Form2 Raport = new Form2();

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

            pula.ResetujPule();
        }

        private void buttonZasady_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "W grze mamy trzech graczy: Zbycha, Helgę i Eustachego.\n" +
                "Każdy z nich próbuje zgadnąć, który z jednorożców dobiegnie do mety jako pierwszy.\n" +
                "Na każdego jednorożca można obstawić kwotę od 5 do 40 PLN. " +
                "Można też nie obstawiać w ogóle.\n" +
                "Wszyscy gracze zaczynąją z kwotą 100 PLN.\nZ każdą rundą do puli dokładane jest 5 PLN.\n" +
                "Wygrywa ten gracz, który podwoi swoją gotówkę!\n",
                "Zasady gry");
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
                pula.UstawIndeksWygrywajacegoJednorozca(0);
                J1.Wygrana();
                zakonczTure();
            }
            else if (J2.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.UstawIndeksWygrywajacegoJednorozca(1);
                J2.Wygrana();
                zakonczTure();
            }
            else if (J3.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.UstawIndeksWygrywajacegoJednorozca(2);
                J3.Wygrana();
                zakonczTure();
            }
            else if (J4.CzyJuzWygral() == true)
            {
                timer1.Stop();
                pula.UstawIndeksWygrywajacegoJednorozca(3);
                J4.Wygrana();
                zakonczTure();
            }
        }

        private void zakonczTure()
        {
            szczescieGraczy();
            generujRaport();
            resetForm();

            int graczeSplukani = 0;
            for (int i = 0; i < gracze.Length; i++)
            {
                if (gracze[i].KasaGracza() == 0) graczeSplukani++;
            }
            if (graczeSplukani == 3)
            {
                if (MessageBox.Show("Nikt już nie ma pieniędzy. Bank wygrywa!\nCzy grać jeszcze raz?", "Ups!",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    resetujGre();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void szczescieGraczy()
        {
            for (int i = 0; i < gracze.Length; i++)
            {
                if ((zaklady[i].PodajNumerJednorozca() - 1) == pula.PokazIndeksWygrywajacegoJednorozca())
                {
                    pula.UstawSzczesliwegoGracza(i);
                }                    
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
            buttonZasady.Enabled = true;

            for (int i = 0; i < zaklady.Length; i++)
            {
                zaklady[i].ResetujZaglosowanie();
            }

            pula.ResetujPule();
            labelPula.Text = Convert.ToString(pula.StanPuli());

            labelZbychuZaklad.Text = "Czekam na zakład Zbycha...";
            labelHelgaZaklad.Text = "Czekam na zakład Helgi...";
            labelEustachyZaklad.Text = "Czekam na zaklad Eustachego...";

            label1.Text = "ma aktualnie " + gracze[comboBoxGracz.SelectedIndex].KasaGracza() + " PLN";
        }

        private void generujRaport()
        {
            for (int i = 0; i < zaklady.Length; i++)
            {
                if (zaklady[i].CzyZaglosowano() == false)
                {
                    Raport.DodajDoRaportu(zaklady[i].ImieGracza() + " w tej rundzie nie obstawia.");
                }
                else
                {
                    Raport.DodajDoRaportu(gracze[i].ImieGracza() + " ma " + (gracze[i].KasaGracza() + zaklady[i].PodajKwoteZakladu()) +
                        " PLN. Obstawia " + zaklady[i].PodajKwoteZakladu() + " PLN na jednorożca o numerze " +
                        zaklady[i].PodajNumerJednorozca() + ".");
                }
            }
            Raport.DodajDoRaportu("\n");

            Raport.DodajDoRaportu("Wygrał jednorożec o numerze " +
                    (pula.PokazIndeksWygrywajacegoJednorozca() + 1) + ".\r\n");

            for (int i = 0; i < gracze.Length; i++)
            {
                if (pula.PokazSzczescieGracza(i) == true)
                {
                    Raport.DodajDoRaportu(gracze[i].ImieGracza() + " obstawia poprawnie!");
                }
                else
                {
                    Raport.DodajDoRaportu(gracze[i].ImieGracza() + " tym razem nie wygrywa...");
                }
            }
            Raport.DodajDoRaportu("\n");

            Raport.DodajDoRaportu("Aktualny stan puli to " + pula.StanPuli() + " PLN.\r\n");

            analizujWynik();

            Raport.ShowDialog();
        }

        private void analizujWynik()
        {
            int sumaWygrywajacych = 0;
            decimal doRozdania = 0;
            for (int i = 0; i < gracze.Length; i++)
            {
                if (pula.PokazSzczescieGracza(i) == true)
                {
                    sumaWygrywajacych++;
                }
            }

            if (sumaWygrywajacych == 0)
            {
                Raport.DodajDoRaportu("Nikt nie wygrywa. Kumulacja! W puli obecnie " + (pula.StanPuli() + 5) + " PLN.");
                pula.Kumulacja(pula.StanPuli());
            }

            else if (sumaWygrywajacych == 1)
            {
                Raport.DodajDoRaportu("Wygrywa tylko jeden gracz.\r\n");
                for (int i = 0; i < gracze.Length; i++)
                {
                    if (pula.PokazSzczescieGracza(i) == true)
                    {
                        gracze[i].DodajKase(pula.StanPuli());
                        Raport.DodajDoRaportu(gracze[i].ImieGracza() + " zgarnia z puli " + pula.StanPuli() + " PLN!" +
                            " i ma obecnie " + gracze[i].KasaGracza() + " PLN.");
                    }
                    pula.ResetujKumulacje();
                }
            }

            else if (sumaWygrywajacych == 2)
            {
                Raport.DodajDoRaportu("Wygrywają dwaj gracze.\r\n");
                doRozdania = Decimal.Round((pula.StanPuli() / 2), 2);
                for (int i = 0; i < gracze.Length; i++)
                {
                    if (pula.PokazSzczescieGracza(i) == true)
                    {
                        gracze[i].DodajKase(doRozdania);
                        Raport.DodajDoRaportu(gracze[i].ImieGracza() + " zgarnia z puli " + doRozdania + " PLN" +
                            " i ma obecnie " + gracze[i].KasaGracza() + " PLN.");
                    }
                    pula.ResetujKumulacje();
                }
            }

            else if (sumaWygrywajacych == 3)
            {
                Raport.DodajDoRaportu("Wszyscy wygrywają!\r\n");
                doRozdania = Decimal.Round((pula.StanPuli() / 3), 2);
                for (int i = 0; i < gracze.Length; i++)
                {
                    if (pula.PokazSzczescieGracza(i) == true)
                    {
                        gracze[i].DodajKase(doRozdania);
                        Raport.DodajDoRaportu(gracze[i].ImieGracza() + " zgarnia z puli " + doRozdania + " PLN" +
                            " i ma obecnie " + gracze[i].KasaGracza() + " PLN.");
                    }
                    pula.ResetujKumulacje();
                }
            }

            for (int i = 0; i < gracze.Length; i++)
            {
                if (gracze[i].KasaGracza() >= 105)
                {
                    Raport.DodajDoRaportu("\n");
                    decimal[] wyniki = new decimal[3];
                    for (int j = 0; j < wyniki.Length; j++)
                    {
                        wyniki[j] = gracze[j].KasaGracza();
                    }
                    int zwyciezca = Array.IndexOf(wyniki, wyniki.Max());
                    Raport.DodajDoRaportu(gracze[zwyciezca].ImieGracza() + " wygrywa grę!");

                    if (MessageBox.Show(gracze[zwyciezca].ImieGracza() + " wygrywa!\n\nCzy grać jeszcze raz?", "Gratulacje!",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        resetujGre();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void resetujGre()
        {
            for (int i = 0; i < gracze.Length; i++)
            {
                gracze[i].Resetuj();
                pula.ResetujPule();
                pula.ResetujKumulacje();
                resetForm();
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Raport.ResetujRaport();
            buttonPodpiszZaklad.Enabled = false;
            buttonStart.Enabled = false;
            buttonZasady.Enabled = false;
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

            else if (
                (gracze[comboBoxGracz.SelectedIndex].KasaGracza() -
                numericUpDownKwotaZakladu.Value) < 0)
            {
                MessageBox.Show(Convert.ToString(comboBoxGracz.SelectedItem) + " nie ma tyle pieniędzy!",
                    "Niestety...");
            }

            else if ((comboBoxGracz.SelectedIndex == 0) && (zaklady[0].CzyZaglosowano() == false))
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

            gracze[comboBoxGracz.SelectedIndex].OdejmijKase(
                Convert.ToInt16(numericUpDownKwotaZakladu.Value));

            pula.DodajDoPuli(Convert.ToInt16(
                zaklady[comboBoxGracz.SelectedIndex].PodajKwoteZakladu()));
            labelPula.Text = Convert.ToString(pula.StanPuli());

            label1.Text = "ma aktualnie " + gracze[comboBoxGracz.SelectedIndex].KasaGracza() + " PLN";
        }

        private void comboBoxGracz_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "ma aktualnie " + gracze[comboBoxGracz.SelectedIndex].KasaGracza() + " PLN";
        }
    }
}
