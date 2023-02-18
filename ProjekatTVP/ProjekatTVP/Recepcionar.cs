using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class Recepcionar : Form
    {
        List<Rezervacije> rezervacije;
        List<Soba> listaSoba;
        List<Gost> listaGost;
        int irez = 0;
        int brlinije = 0;
        int brliste = 0;
        int isoba = 0;
        int ig = 0;

        public Recepcionar()
        {
            InitializeComponent();
            rezervacije = new List<Rezervacije>();
            listaSoba = new List<Soba>();
            listaGost = new List<Gost>();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Recepcionar_Load(object sender, EventArgs e)
        {
            string putanja = "rezervacije.txt";
            List<string> linije = File.ReadAllLines(putanja).ToList();
            foreach (var red in linije)
            {
                Rezervacije r = new Rezervacije();
                string[] celo = red.Split(',');
                r.Id = int.Parse(celo[0]);
                r.Idsobe = int.Parse(celo[1]);
                r.Idgosta = int.Parse(celo[2]);
                string[] borivoje = celo[3].Split('-');
                r.Datumod = new DateTime(int.Parse(borivoje[0]), int.Parse(borivoje[1]), int.Parse(borivoje[2]));
                string[] slavoljub = celo[4].Split('-');
                r.Datumdo = new DateTime(int.Parse(slavoljub[0]), int.Parse(slavoljub[1]), int.Parse(slavoljub[2]));
                r.Cena = int.Parse(celo[5]);
                r.Tip = celo[6];
                if (r.Datumod.Subtract(DateTime.Now).TotalDays >= 0 || r.Datumdo.Subtract(DateTime.Now).TotalDays >= 0)
                {
                    rezervacije.Add(r);
                    
                }
                irez++;
            }
            listBox1.DataSource = rezervacije;
            linije.Clear();
            putanja = "sobe.txt";
            linije = File.ReadAllLines(putanja).ToList();
            foreach (var red in linije)
            {
                Soba s = new Soba();
                string[] celo = red.Split(',');
                s.Id = int.Parse(celo[0].ToString());
                s.Brsobe = int.Parse(celo[1].ToString());
                s.Brkreveta = int.Parse(celo[2].ToString());
                s.Tip = celo[3];
                s.Cena = int.Parse(celo[4].ToString());
                s.Popust = int.Parse(celo[5].ToString());
                s.Mindana = int.Parse(celo[6].ToString());
                listaSoba.Add(s);
                isoba++;

            }
            linije.Clear();
            putanja = "gosti.txt";
            linije = File.ReadAllLines(putanja).ToList();
            foreach (var red in linije)
            {
                Gost g = new Gost();
                string[] celo = red.Split(',');
                g.Id = int.Parse(celo[0].ToString());
                g.Ime = celo[1];
                g.Prezime = celo[2];
                string[] borivoje = celo[3].Split('-');
                g.Datum = new DateTime(int.Parse(borivoje[0]), int.Parse(borivoje[1]), int.Parse(borivoje[2]));
                g.Telefon = celo[4];
                listaGost.Add(g);
                ig++;
            }
        }
        //brisanje
        private void button2_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                int ajdi = int.Parse(textID.Text);
                int i = 0;
                int pom = 0;
                string putanja = "rezervacije.txt";
                List<string> linije = File.ReadAllLines(putanja).ToList();
                foreach (var red in linije)
                {
                    string[] celo = red.Split(',');
                    i++;
                    if (celo[0] == ajdi.ToString())
                    {
                        brlinije = i;
                        pom = 1;
                    }
                }
                for(i =0;i<rezervacije.Count;i++)
                {
                    if (rezervacije[i].Id == ajdi)
                    {
                        brliste = i;
                        pom = 1;
                    }
                }
                if (pom == 1)
                {
                    linije.RemoveAt(brlinije - 1);
                    rezervacije.RemoveAt(brliste);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        string[] drakce = linije[i].Split(',');
                        linije[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5] + "," + drakce[6];
                    }
                    File.WriteAllLines(putanja, linije);
                    for (i = brliste; i < rezervacije.Count; i++)
                    {
                        rezervacije[i].Id = rezervacije[i].Id - 1;
                    }
                    listBox1.DataSource = null;
                    listBox1.DataSource = rezervacije;
                    MessageBox.Show("Uspesno ste uradili radnju");
                }
                else
                {
                    MessageBox.Show("Niste uneli lepo polje");
                }
            }
            else
            {
                MessageBox.Show("Niste uneli ID");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                if (textIDSobe.Text != "" && textIDGosta.Text != "" && textRezCena.Text != "" && textRezTip.Text != "")
                {
                    if (textIDSobe.Text.All(Char.IsDigit) && textIDGosta.Text.All(Char.IsDigit) && textRezCena.Text.All(Char.IsDigit) && !textRezTip.Text.Any(char.IsDigit))
                    {
                        if (int.Parse(textIDSobe.Text) <= isoba && int.Parse(textIDGosta.Text) <= ig)
                        {
                            if (dateTimePicker2.Value.Subtract(dateTimePicker3.Value).TotalDays >= listaSoba[int.Parse(textIDSobe.Text) - 1].Mindana)
                            {
                                int ajdi = int.Parse(textID.Text) - 1;
                                int i = 0;
                                for (i = 0; i < rezervacije.Count; i++)
                                {
                                    if (rezervacije[i].Id == ajdi)
                                    {
                                        brliste = i;
                                    }
                                }
                                rezervacije[brliste+1].Idgosta = int.Parse(textIDGosta.Text);
                                rezervacije[brliste+1].Idsobe = int.Parse(textIDSobe.Text);
                                rezervacije[brliste+1].Datumod = dateTimePicker3.Value;
                                rezervacije[brliste+1].Datumdo = dateTimePicker2.Value;
                                rezervacije[brliste+1].Cena = int.Parse(textRezCena.Text);
                                rezervacije[brliste+1].Tip = textRezTip.Text;
                                string putanja = "rezervacije.txt";
                                List<string> linije = File.ReadAllLines(putanja).ToList();
                                string[] drakce = linije[ajdi].Split(',');
                                linije[ajdi] = (int.Parse(drakce[0])) + "," + textIDSobe.Text + "," + textIDGosta.Text + "," + dateTimePicker3.Value.ToString("yyyy/MM/dd") + "," + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "," + textRezCena.Text + "," + textRezTip.Text;
                                File.WriteAllLines(putanja, linije);
                                listBox1.DataSource = null;
                                listBox1.DataSource = rezervacije;
                                MessageBox.Show("Uspesno ste uradili radnju");
                            }
                            else
                            {
                                MessageBox.Show("Za datu sobu uslov nije ispunjen(minimalni broj soba).");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Za datu sobu uslov nije ispunjen(minimalni broj soba).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Niste uneli kako treba podatke");
                    }
                }
                else
                {
                    MessageBox.Show("Ostavili ste prazna polja");
                }
            }
            else
            {
                MessageBox.Show("Niste uneli ID");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dodaj dodaj = new Dodaj();
            dodaj.ShowDialog();
            this.Close();
        }
    }
}
