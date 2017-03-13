using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wczytywanie_ZPliku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int[][] daneZPliku;


        int[] WartosciDecyzji()
        {
            List<int> decyzje = new List<int>();
            int decyzja;


           
            for (int i = 0; i < daneZPliku.Length; i ++)
            {
                decyzja = daneZPliku[i].Last();

                decyzje.Add(decyzja);
            }

            decyzje = decyzje.Distinct().ToList();

            return decyzje.ToArray(); 
        }

        int[] WartosciZKlasy(int[][] tab, int decyzja, int indeksAtrybutu)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].Last() == decyzja)
                {
                    lista.Add(tab[i][indeksAtrybutu]);
                }
            }

            return lista.ToArray();
        }

        int[] WartosciPozostale(int[][] tab, int decyzja, int indeksAtrybutu)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i].Last() != decyzja)
                {
                    lista.Add(tab[i][indeksAtrybutu]);
                }
            }

            return lista.ToArray();
        }


       
        double Srednia (int [] tab)
        {
            double suma = 0;
            double srednia = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma = suma + tab[i];
            }


            srednia = suma / tab.Length;

            return srednia;
        }
       
        double Wariancja (int [] tab, double srednia)
        {
            double suma = 0;
            double wariancja = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                suma = suma + ((tab[i] - srednia)* (tab[i] - srednia));
            }

            wariancja = suma / tab.Length;

            return wariancja;
        }
        
        double Separacje (int[][] tab, int decyzja, int atrybut)
        {
            int[] wartObKlasy = WartosciZKlasy(tab, decyzja, atrybut);
            int[] wartReszty = WartosciPozostale(tab, decyzja, atrybut);
            int cardC = wartObKlasy.Length;
            int cardU = daneZPliku.Length;

            double cZKlasy = 0;
            double cPozaKl = 0;
            double zZKlasy = 0;
            double zPozaKl = 0;
            double separacja = 0;

            cZKlasy = Srednia(wartObKlasy);
            cPozaKl = Srednia(wartReszty);
            zZKlasy = Wariancja(wartObKlasy, cZKlasy);
            zPozaKl = Wariancja(wartReszty, cPozaKl);

            separacja = Math.Pow((cZKlasy - cPozaKl), 2) / (zZKlasy + zPozaKl); 

            return separacja;
        }

       
        Dictionary<int, Dictionary<int, double>> NrAtrybutow(int[] tablicaZDecyzjami)
        {
            Dictionary<int, Dictionary<int, double>> NrAtrybutuIWartosc = new Dictionary<int, Dictionary<int, double>>();

            List<int> listaDecyzji = new List<int>();
            listaDecyzji = tablicaZDecyzjami.ToList();

            int iloscAtrybutow = daneZPliku[0].Length - 1;

            foreach (var decyzja in listaDecyzji) 
            {
                NrAtrybutuIWartosc.Add(decyzja, SeparacjaKlasyDecyzyjnej(decyzja));
            }

            return NrAtrybutuIWartosc;
        }


        Dictionary<int, double> SeparacjaKlasyDecyzyjnej(int decyzja)
        {
            Dictionary<int, double> slSeparacje = new Dictionary<int, double>();

            int iloscAtrybutow = daneZPliku[0].Length - 1;

            for (int i = 0; i < iloscAtrybutow; i++)
            {
                slSeparacje.Add(i, Separacje(daneZPliku, decyzja, i));
            }

            slSeparacje = slSeparacje.OrderByDescending(s => s.Value).ToDictionary(s => s.Key, s => s.Value);

            return slSeparacje;
        }

        

        List<int> NajlepszeSeparacje (Dictionary<int, Dictionary<int, double>> slownik)
        {
            List<int> lista = new List<int>();

            int iloscPobrana = int.Parse(IloscAtrybutow.Text);

            int licznikZnalezionych = 0;

            while (licznikZnalezionych < iloscPobrana)
            {
                foreach (var decyzja in slownik)
                {
                    if (lista.Count < iloscPobrana)
                    {
                        if (!lista.Contains(decyzja.Value.First().Key))
                        {
                            lista.Add(decyzja.Value.First().Key);
                            decyzja.Value.Remove(decyzja.Value.First().Key);
                            licznikZnalezionych++;
                        }

                        else decyzja.Value.Remove(decyzja.Value.First().Key);
                    }
                }
            }

            return lista;
        }

    

        string Wynik(List<int> listaZIndeksami)
        {
            string wynik = "";
            List<int> lista = new List<int>();
            lista = listaZIndeksami;

            int iloscWierszy = daneZPliku.Length;

            int indeksDecyzji = daneZPliku[0].Length - 1;
            lista.Add(indeksDecyzji);

            for (int i = 0; i < iloscWierszy; i++)
            {
                foreach (var indeks in lista)
                {
                    var result = string.Join(" ", daneZPliku[i][indeks]);
                    wynik = wynik + " " + result.ToString();
                }

                wynik = wynik + "\r\n";
            }

            return wynik;
        }


        /*obsługa przycisków*/

        private void WybierzSystem_Click(object sender, EventArgs e)
        {
            var wynik = ofd.ShowDialog();
            if (wynik != DialogResult.OK)
                return;



            if (wynik == DialogResult.OK)
            {

                tbSciezka.Text = ofd.FileName;
                string trescPliku = System.IO.File.ReadAllText(ofd.FileName);


                string[] poziomy = trescPliku.Split('\n');

                daneZPliku = new int[poziomy.Length][];

                for (int i = 0; i < poziomy.Length; i++)
                {
                    string poziom = poziomy[i].Trim();
                    string[] miejscaParkingowe = poziom.Split(' ');
                    daneZPliku[i] = new int[miejscaParkingowe.Length];
                    for (int j = 0; j < miejscaParkingowe.Length; j++)
                    {
                        daneZPliku[i][j] = int.Parse(miejscaParkingowe[j]);

                    }
                }


                WczytanySystem.Text = trescPliku;
                IloscAtrybutow.Maximum = (daneZPliku[0].Length - 1);
                Generuj.Enabled = true;

            }

           
         
        }
    
        private void WczytanySystem_Load(object sender, EventArgs e)
        {
            ofd.Filter = "Text Filrd (.txt) |*.txt";
            Generuj.Enabled = false;
        }
        

        private void Generuj_Click(object sender, EventArgs e)
        {
            if (daneZPliku != null)
            {
                string wynik = "";

                int[] decyzje = WartosciDecyzji();

                Dictionary<int, Dictionary<int, double>> slownik = new Dictionary<int, Dictionary<int, double>>();
                slownik = NrAtrybutow(decyzje);
                List<int> listaAtrybutow = new List<int>();
                listaAtrybutow = NajlepszeSeparacje(slownik);

                wynik = Wynik(listaAtrybutow);

                
                KoncowaSelekcja.Text = wynik;
            }
            else 
            {
                Generuj.Enabled = false;

            }

           

        }


        private void IloscAtrybutow_ValueChanged(object sender, EventArgs e)
        {

            if(IloscAtrybutow.Value < 1)
            {
                KoncowaSelekcja.Text = "Wybierz liczbę atrubutów większą od 0!";
                Generuj.Enabled = false;
            }
            else
            {
                KoncowaSelekcja.Text = "";
                Generuj.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void KoncowaSelekcja_TextChanged(object sender, EventArgs e)
        {

        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            WczytanySystem.Text = "";
            KoncowaSelekcja.Text = "";
            tbSciezka.Text = "";
        }

        private void zamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
