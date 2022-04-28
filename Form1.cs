using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skoki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double WSP;
        public double Wynik;
        public string Przerwa1;
        public string Przerwa2;
        public string Przerwa3;


        private void button1_Click(object sender, EventArgs e)
        {
            string Punkt_K_str = textBox1.Text;
            double Punkt_K = Convert.ToDouble(Punkt_K_str);
            string Pkt_za_1_sk_str = textBox2.Text;
            double Pkt_za_1_sk = Convert.ToDouble(Pkt_za_1_sk_str);
            string Komp_za_belk_str = textBox3.Text;
            double Komp_za_belk = Convert.ToDouble(Komp_za_belk_str);
            string Odleglosc_str = textBox4.Text;
            double Odleglosc = Convert.ToDouble(Odleglosc_str);
            string Komp_za_wiatr_str = textBox5.Text;
            double Komp_za_wiatr = Convert.ToDouble(Komp_za_wiatr_str);
            string Nota1_str = textBox6.Text;
            double Nota1 = Convert.ToDouble(Nota1_str);
            string Nota2_str = textBox7.Text;
            double Nota2 = Convert.ToDouble(Nota2_str);
            string Nota3_str = textBox8.Text;
            double Nota3 = Convert.ToDouble(Nota3_str);
            string Nota4_str = textBox9.Text;
            double Nota4 = Convert.ToDouble(Nota4_str);
            string Nota5_str = textBox10.Text;
            double Nota5 = Convert.ToDouble(Nota5_str);

            if (80 < Punkt_K && Punkt_K <= 99)
            {
                WSP = 2;
            }

            if (100 < Punkt_K && Punkt_K <= 169)
            {
                WSP = 1.8;
            }

            if (170 <= Punkt_K)
            {
                WSP = 1.2;
            }

            double[] Noty = { Nota1, Nota2, Nota3, Nota4, Nota5 };
            double Najwieksza = Noty[0];
            for (int i = 0; i < 5; i++)
            {
                if (Noty[i] > Najwieksza)
                {
                    Najwieksza = Noty[i];
                }
            }

            double Najmniejsza = Noty[0];
            for (int i = 0; i < 5; i++)
            {
                if (Noty[i] < Najmniejsza)
                {
                    Najmniejsza = Noty[i];
                }
            }

            if (170 <= Punkt_K)
            {
                Wynik = Pkt_za_1_sk + 120 + ((Odleglosc - Punkt_K) * WSP) + Nota1 + Nota2 + Nota3 + Nota4 + Nota5 - Najwieksza - Najmniejsza + Komp_za_belk + Komp_za_wiatr;
            }

            else if (Punkt_K < 170)
            {
                Wynik = Pkt_za_1_sk + 60 + ((Odleglosc - Punkt_K) * WSP) + Nota1 + Nota2 + Nota3 + Nota4 + Nota5 - Najwieksza - Najmniejsza + Komp_za_belk + Komp_za_wiatr;
            }

            //textBox11.Text = Wynik.ToString();
            if (10 > Wynik)
            {
                string Wynik_str = Convert.ToString(Wynik);
                Wynik_str = "    " + Wynik_str;
                textBox11.Text = Wynik_str;
                textBox14.Text = textBox4.Text;
                textBox15.Text = textBox11.Text;
            }


            if (10 <= Wynik && Wynik < 100)
            {
                string Wynik_str = Convert.ToString(Wynik);
                Wynik_str = "  " + Wynik_str;
                textBox11.Text = Wynik_str;
                textBox14.Text = textBox4.Text;
                textBox15.Text = textBox11.Text;
            }

            if (Wynik >= 100)
            {
                string Wynik_str = Convert.ToString(Wynik);
                textBox11.Text = Wynik_str;
                textBox14.Text = textBox4.Text;
                textBox15.Text = textBox11.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            string[] Zawodnik = { textBox15.Text, textBox12.Text, textBox13.Text, textBox14.Text };
            string Zawodnik_Str = Convert.ToString(Zawodnik);
            
            // Długość PIERWSZEJ przerwy
            if (Zawodnik[0].Length <= 7)
            {
                Przerwa1 = "\t" + "\t" + "\t";
            }

            if (Zawodnik[0].Length > 7 && Zawodnik[0].Length <= 15)
            {
                Przerwa1 = "\t" + "\t";
            }

            if (Zawodnik[0].Length > 15 && Zawodnik[0].Length <= 23)
            {
                Przerwa1 = "\t";
            }

            if (Zawodnik[0].Length > 23)
            {
                Przerwa1 = "";
            }

            // Długość DRUGIEJ przerwy
            if (Zawodnik[1].Length <= 7)
            {
                Przerwa2 = "\t" + "\t" + "\t";
            }

            if (Zawodnik[1].Length > 7 && Zawodnik[1].Length <= 15)
            {
                Przerwa2 = "\t" + "\t";
            }

            if (Zawodnik[1].Length > 15 && Zawodnik[1].Length <= 23)
            {
                Przerwa2 = "\t";
            }

            if (Zawodnik[1].Length > 23)
            {
                Przerwa2 = "";
            }

            // Długość TRZECIEJ przerwy
            if (Zawodnik[2].Length <= 7)
            {
                Przerwa3 = "\t" + "\t" + "\t";
            }

            if (Zawodnik[2].Length > 7 && Zawodnik[2].Length <= 15)
            {
                Przerwa3 = "\t" + "\t";
            }

            if (Zawodnik[2].Length > 15 && Zawodnik[2].Length <= 23)
            {
                Przerwa3 = "\t";
            }

            if (Zawodnik[2].Length > 23)
            {
                Przerwa3 = "";
            }

            string Tablica_Wynikow = Zawodnik[0] + Przerwa1 + Zawodnik[1] + Przerwa2 + Zawodnik[2] + Przerwa3 + Zawodnik[3];

            //listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Items.Add(Tablica_Wynikow + "\r\n");
            //listBox1.Sorted = true;

            ArrayList list = new ArrayList();
            foreach (var item in listBox1.Items)
            {
                list.Add(item);
            }
            list.Sort();
            list.Reverse();

            listBox1.Items.Clear();

            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
            
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();

            if(textBox2.Text != "0")
            {
                textBox2.Clear();
            }
            
            //textBox16.Text = Zawodnik[0] + Zawodnik[1] + Zawodnik[2] + Zawodnik[3] + Environment.NewLine;
        }
    }
}
