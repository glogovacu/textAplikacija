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
    public partial class Dodaj : Form
    {
        int ig = 0;
        int ik = 0;
        int isoba = 0;
        int irez = 0;
        int brlinije = 0;

        List<Gost> listaGost;
        List<Korisnik> korisnici;
        List<Soba> listaSoba;
        List<Rezervacije> rezervacije;
        List<Soba> listaSoba2;
        List<Soba> novasoba;
        
        public Dodaj()
        {
            InitializeComponent();
            listaGost = new List<Gost>();
            korisnici = new List<Korisnik>();
            listaSoba = new List<Soba>();
            rezervacije = new List<Rezervacije>();
            listaSoba2 = new List<Soba>();
            novasoba = new List<Soba>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textImeGost.Text != "" && textPrezimeGost.Text != "" && textGostTelefon.Text != "")
            {
                if (!textImeGost.Text.Any(char.IsDigit) && !textPrezimeGost.Text.Any(char.IsDigit) && textGostTelefon.Text.All(Char.IsDigit))
                {
                    Gost g = new Gost();
                    string putanja = "gosti.txt";
                    DateTime datum = dateTimePicker1.Value;
                    List<string> linije = File.ReadAllLines(putanja).ToList();
                    ig = 1;
                    foreach (var red in linije)
                    {
                        string[] celo = red.Split(',');

                        if (ig.ToString() == celo[0])
                        {

                            ig++;

                        }
                    }

                    string borivoje = (ig) + "," + textImeGost.Text + "," + textPrezimeGost.Text + "," + datum.ToString("yyyy/MM/dd") + "," + textGostTelefon.Text + Environment.NewLine;

                    File.AppendAllText(putanja, borivoje);
                    g.Id = ig;
                    g.Ime = textImeGost.Text;
                    g.Prezime = textPrezimeGost.Text;
                    g.Datum = datum;
                    g.Telefon = textGostTelefon.Text;
                    listaGost.Add(g);
                    listBox1.DataSource = null;
                    listBox1.DataSource = listaGost;
                    MessageBox.Show("Uspesno ste uradili radnju");
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

        private void Dodaj_Load(object sender, EventArgs e)
        {
            string putanja = "korisnici.txt";
            List<string> linije = File.ReadAllLines(putanja).ToList();
            foreach (var red in linije)
            {
                Korisnik k = new Korisnik();
                string[] celo = red.Split(',');
                k.Id = int.Parse(celo[0].ToString());
                k.Ime = celo[1];
                k.Prezime = celo[2];
                k.Username = celo[3];
                k.Password = celo[4];
                k.Pozicija = celo[5];
                korisnici.Add(k);
                ik++;
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
            listBox1.DataSource = listaGost;
            
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
            listaSoba2 = new List<Soba>(listaSoba);
            listBox2.DataSource = listaSoba2;
            
            linije.Clear();
            putanja = "rezervacije.txt";
            linije = File.ReadAllLines(putanja).ToList();
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
                rezervacije.Add(r);
                irez++;
                if (r.Datumod > DateTime.Now && r.Datumdo > DateTime.Now)
                {
                    listaSoba2.RemoveAt(r.Idsobe - 1);
                }
            }
            listBox3.DataSource = rezervacije;
            listBox2.DataSource = null;
            listBox2.DataSource = listaSoba2;
        }

        private void UnesiRez_Click(object sender, EventArgs e)
        {
            if (textIDSobe.Text != "" && textIDGosta.Text != "" && textRezTip.Text != "")
            {
                if (textIDSobe.Text.All(Char.IsDigit) && textIDGosta.Text.All(Char.IsDigit) && !textRezTip.Text.Any(char.IsDigit))
                {
                    if (int.Parse(textIDSobe.Text) <= isoba && int.Parse(textIDGosta.Text) <= ig)
                    {
                        if (dateTimePicker2.Value.Subtract(dateTimePicker3.Value).TotalDays >= listaSoba[int.Parse(textIDSobe.Text) - 1].Mindana)
                        {
                            for (int i = 0; i < listaSoba2.Count; i++)
                            {
                                if (listaSoba2[i].Id == int.Parse(textIDSobe.Text))
                                {
                                    ik = 1;
                                }
                                
                            }
                            if(ik==1)
                            { 
                            Rezervacije r = new Rezervacije();
                            string putanja = "rezervacije.txt";
                            List<string> linije = File.ReadAllLines(putanja).ToList();
                            irez = 1;
                            foreach (var red in linije)
                            {
                                string[] celo = red.Split(',');

                                if (irez.ToString() == celo[0])
                                {

                                    irez++;

                                }
                            }
                            
                            r.Id = irez;
                            r.Idsobe = int.Parse(textIDSobe.Text);
                            r.Idgosta = int.Parse(textIDGosta.Text);
                            r.Datumod = dateTimePicker3.Value;
                            r.Datumdo = dateTimePicker2.Value;
                            r.Cena = listaSoba[int.Parse(textIDSobe.Text) - 1].Cena - listaSoba[int.Parse(textIDSobe.Text) - 1].Popust;
                            r.Tip = textRezTip.Text;
                            rezervacije.Add(r);
                            string borivoje = (irez) + "," + textIDSobe.Text + "," + textIDGosta.Text + "," + dateTimePicker3.Value.ToString("yyyy/MM/dd") + "," + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "," + (listaSoba[(rezervacije[irez-1].Idsobe)-1].Cena - listaSoba[(rezervacije[irez-1].Idsobe)-1].Popust) + "," + textRezTip.Text + Environment.NewLine;
                            File.AppendAllText(putanja, borivoje);

                            listBox3.DataSource = null;
                            listBox3.DataSource = rezervacije;
                            MessageBox.Show("Uspesno ste dodali rezervaciju");
                            this.Hide();
                            Recepcionar rec = new Recepcionar();
                            rec.ShowDialog();
                            this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Uneli ste zauzetu sobu");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Za datu sobu uslov nije ispunjen(minimalni broj soba).");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID Sobe ili ID Gosta ne postoji.");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1 != null)
            {
                if(comboBox1.Text == "lux")
                {
                    int j = 0;
                    
                    for(int i = 0; i < listaSoba.Count; i++)
                    {
                        if(listaSoba[i].Tip == "lux")
                        {
                            novasoba.Add(listaSoba[i]);
                        }
                    }
                }
                if (comboBox1.Text == "standard")
                {
                    int j = 0;

                    for (int i = 0; i < listaSoba.Count; i++)
                    {
                        if (listaSoba[i].Tip == "standard")
                        {
                            novasoba.Add(listaSoba[i]);
                        }
                    }
                }
                listBox2.DataSource = null;
                listBox2.DataSource = novasoba;
                novasoba.Clear();
                MessageBox.Show("Uspesno ste uradili radnju");
            }
            else
            {
                MessageBox.Show("Unesite standard ili lux");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                int j = 0;

                for (int i = 0; i < listaSoba.Count; i++)
                {
                    if (listaSoba[i].Brkreveta == numericUpDown1.Value)
                    {
                        novasoba.Add(listaSoba[i]);
                    }
                }
                listBox2.DataSource = null;
                listBox2.DataSource = novasoba;
                novasoba.Clear();
                MessageBox.Show("Uspesno ste uradili radnju");

            }
            else
            {
                MessageBox.Show("Unesite validan broj kreveta");
            }
        }
    }
}
