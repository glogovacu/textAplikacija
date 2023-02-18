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
    public partial class Admin : Form
    {
        int i;
        int ig = 0;
        int ik = 0;
        int isoba = 0;
        int irez = 0;
        int brlinije = 0;

        List<Gost> listaGost;
        List<Korisnik> korisnici;
        List<Soba> listaSoba;
        List<Rezervacije> rezervacije;
        public Admin()
        {
            InitializeComponent();
            listaGost = new List<Gost>();
            korisnici = new List<Korisnik>();
            listaSoba = new List<Soba>();
            rezervacije = new List<Rezervacije>();
        }

        private void Admin_Load(object sender, EventArgs e)
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
            listBox4.DataSource = korisnici;
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
            listBox2.DataSource = listaSoba;
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
            }
            listBox3.DataSource = rezervacije;
        }
        //dodavanje gosta
        private void button9_Click(object sender, EventArgs e)
        {
            if (textImeGost.Text!= "" && textPrezimeGost.Text != "" && textGostTelefon.Text != "")
            {
                if(!textImeGost.Text.Any(char.IsDigit) && !textPrezimeGost.Text.Any(char.IsDigit) && textGostTelefon.Text.All(Char.IsDigit)){ 
            Gost g = new Gost();
            string putanja = "gosti.txt";
            DateTime datum= dateTimePicker1.Value;
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

        private void button13_Click(object sender, EventArgs e)
        {
               
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }
        //Brisanje Gosta
        private void button2_Click(object sender, EventArgs e)
        {
            if(textID.Text != ""){ 
            int ajdi = int.Parse(textID.Text);
            int i = 0;
            int pom = 0;
            string putanja = "gosti.txt";
            List<string> linije = File.ReadAllLines(putanja).ToList();
            foreach (var red in linije)
            {
                string[] celo = red.Split(',');
                i++;
                if(celo[0]== ajdi.ToString())
                {
                    brlinije = i;
                    pom = 1;
                }
            }
            if(pom==1)
            { 
            linije.RemoveAt(brlinije-1);
            listaGost.RemoveAt(brlinije-1);
                for(i=brlinije-1; i < linije.Count;i++)
                { string[] drakce = linije[i].Split(',');
                    linije[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4];
                 }
            File.WriteAllLines(putanja, linije);
                for (i = brlinije-1; i < linije.Count; i++)
                {
                    listaGost[i].Id = listaGost[i].Id - 1;
                }
                listBox1.DataSource = null;
            listBox1.DataSource = listaGost;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MenjajGosta_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                if (textImeGost.Text != "" && textPrezimeGost.Text != "" && textGostTelefon.Text != "")
            {
                if (!textImeGost.Text.Any(char.IsDigit) && !textPrezimeGost.Text.Any(char.IsDigit) && textGostTelefon.Text.All(Char.IsDigit))
                {
                    int ajdi = int.Parse(textID.Text) -1;
            listaGost[ajdi].Ime = textImeGost.Text;
            listaGost[ajdi].Prezime = textPrezimeGost.Text;
            listaGost[ajdi].Datum = dateTimePicker1.Value;
            listaGost[ajdi].Telefon = textGostTelefon.Text;
            string putanja = "gosti.txt";
            List<string> linije = File.ReadAllLines(putanja).ToList();
            string[] drakce = linije[ajdi].Split(',');
            linije[ajdi] = (int.Parse(drakce[0])) + "," + textImeGost.Text + "," + textPrezimeGost.Text + "," + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "," + textGostTelefon.Text;
            File.WriteAllLines(putanja, linije);
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
            else
            {
                MessageBox.Show("Niste uneli ID");
            }


        }

        private void UnesiSoba_Click(object sender, EventArgs e)
        {
            if (textBrSobe.Text != "" && textBrKreveta.Text != "" && comboBox2.Text != "" && textSobaCena.Text !="" && textSobaPopust.Text != "" && textSobaMin.Text!= ""  )
            {
                if (textBrSobe.Text.All(Char.IsDigit) && textBrKreveta.Text.All(Char.IsDigit) && !comboBox2.Text.Any(char.IsDigit) && textSobaCena.Text.All(Char.IsDigit) && textSobaPopust.Text.All(Char.IsDigit) && textSobaMin.Text.All(Char.IsDigit))
                {
                    Soba s = new Soba();
                    string putanja = "sobe.txt";
                    List<string> linije = File.ReadAllLines(putanja).ToList();
                    isoba = 1;
                    foreach (var red in linije)
                    {
                        string[] celo = red.Split(',');

                        if (isoba.ToString() == celo[0])
                        {

                            isoba++;

                        }
                    }

                    string borivoje = (isoba) + "," + textBrSobe.Text + "," + textBrKreveta.Text + "," + comboBox2.Text + "," + textSobaCena.Text + "," + textSobaPopust.Text + "," + textSobaMin.Text + Environment.NewLine;

                    File.AppendAllText(putanja, borivoje);
                    s.Id = isoba;
                    s.Brsobe = int.Parse(textBrSobe.Text);
                    s.Brkreveta = int.Parse(textBrKreveta.Text);
                    s.Tip = comboBox2.Text;
                    s.Cena = int.Parse(textSobaCena.Text);
                    s.Popust = int.Parse(textSobaPopust.Text);
                    s.Mindana = int.Parse(textSobaMin.Text);
                    listaSoba.Add(s);
                    listBox2.DataSource = null;
                    listBox2.DataSource = listaSoba;
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

        private void BrisiSoba_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                int ajdi = int.Parse(textID.Text);
                int i = 0;
                int pom = 0;
                string putanja = "sobe.txt";
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
                if (pom == 1)
                {
                    linije.RemoveAt(brlinije - 1);
                    listaSoba.RemoveAt(brlinije - 1);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        string[] drakce = linije[i].Split(',');
                        linije[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5] + "," + drakce[6]; 
                    }
                    File.WriteAllLines(putanja, linije);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        listaSoba[i].Id = listaSoba[i].Id - 1;
                    }
                    listBox2.DataSource = null;
                    listBox2.DataSource = listaSoba;
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

        private void MenjajSoba_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                if (textBrSobe.Text != "" && textBrKreveta.Text != "" && comboBox2.Text != "" && textSobaCena.Text != "" && textSobaPopust.Text != "" && textSobaMin.Text != "")
                {
                    if (textBrSobe.Text.All(Char.IsDigit) && textBrKreveta.Text.All(Char.IsDigit) && !comboBox2.Text.Any(char.IsDigit) && textSobaCena.Text.All(Char.IsDigit) && textSobaPopust.Text.All(Char.IsDigit) && textSobaMin.Text.All(Char.IsDigit))
                    {
                        int ajdi = int.Parse(textID.Text) - 1;
                        listaSoba[ajdi].Brsobe = int.Parse(textBrSobe.Text);
                        listaSoba[ajdi].Brkreveta = int.Parse(textBrKreveta.Text);
                        listaSoba[ajdi].Tip = comboBox2.Text;
                        listaSoba[ajdi].Cena = int.Parse(textSobaCena.Text);
                        listaSoba[ajdi].Popust = int.Parse(textSobaPopust.Text);
                        listaSoba[ajdi].Mindana = int.Parse(textSobaMin.Text);
                        string putanja = "sobe.txt";
                        List<string> linije = File.ReadAllLines(putanja).ToList();
                        string[] drakce = linije[ajdi].Split(',');
                        linije[ajdi] = (int.Parse(drakce[0])) + "," + textBrSobe.Text + "," + textBrKreveta.Text + "," + comboBox2.Text + "," + textSobaCena.Text + "," + textSobaPopust.Text + "," + textSobaMin.Text;
                        File.WriteAllLines(putanja, linije);
                        listBox2.DataSource = null;
                        listBox2.DataSource = listaSoba;
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
            else
            {
                MessageBox.Show("Niste uneli ID");
            }
        }

        private void UnesiRez_Click(object sender, EventArgs e)
        {
            if (textIDSobe.Text != "" && textIDGosta.Text != "" && textRezCena.Text != "" && textRezTip.Text != "")
            {
                if (textIDSobe.Text.All(Char.IsDigit) && textIDGosta.Text.All(Char.IsDigit) && textRezCena.Text.All(Char.IsDigit) && !textRezTip.Text.Any(char.IsDigit))
                {
                    if(int.Parse(textIDSobe.Text)<=isoba && int.Parse(textIDGosta.Text) <= ig)
                    {
                        if(dateTimePicker2.Value.Subtract(dateTimePicker3.Value).TotalDays >= listaSoba[int.Parse(textIDSobe.Text)-1].Mindana){ 
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

                    string borivoje = (irez) + "," + textIDSobe.Text + "," + textIDGosta.Text + "," + dateTimePicker3.Value.ToString("yyyy/MM/dd") + "," + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "," + textRezCena.Text + "," + textRezTip.Text + Environment.NewLine;

                    File.AppendAllText(putanja, borivoje);
                    r.Id = irez;
                    r.Idsobe = int.Parse(textIDSobe.Text);
                    r.Idgosta = int.Parse(textIDGosta.Text);
                    r.Datumod = dateTimePicker3.Value;
                    r.Datumdo = dateTimePicker2.Value;
                    r.Cena = int.Parse(textRezCena.Text);
                    r.Tip = textRezTip.Text;
                    rezervacije.Add(r);
                    listBox3.DataSource = null;
                    listBox3.DataSource = rezervacije;
                            MessageBox.Show("Uspesno ste uradili radnju");
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

        private void BrisiRez_Click(object sender, EventArgs e)
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
                if (pom == 1)
                {
                    linije.RemoveAt(brlinije - 1);
                    rezervacije.RemoveAt(brlinije - 1);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        string[] drakce = linije[i].Split(',');
                        linije[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5] + "," + drakce[6];
                    }
                    File.WriteAllLines(putanja, linije);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        rezervacije[i].Id = rezervacije[i].Id - 1;
                    }
                    listBox3.DataSource = null;
                    listBox3.DataSource = rezervacije;
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

        private void MenjajRez_Click(object sender, EventArgs e)
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
                        rezervacije[ajdi].Idgosta = int.Parse(textIDGosta.Text);
                        rezervacije[ajdi].Idsobe = int.Parse(textIDSobe.Text);
                        rezervacije[ajdi].Datumod = dateTimePicker3.Value;
                        rezervacije[ajdi].Datumdo = dateTimePicker2.Value;
                        rezervacije[ajdi].Cena = int.Parse(textRezCena.Text);
                        rezervacije[ajdi].Tip = textRezTip.Text;
                        string putanja = "rezervacije.txt";
                        List<string> linije = File.ReadAllLines(putanja).ToList();
                        string[] drakce = linije[ajdi].Split(',');
                        linije[ajdi] = (int.Parse(drakce[0])) + "," + textIDSobe.Text + "," + textIDGosta.Text + "," + dateTimePicker3.Value.ToString("yyyy/MM/dd") + "," + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "," + textRezCena.Text + "," + textRezTip.Text;
                            File.WriteAllLines(putanja, linije);
                        listBox3.DataSource = null;
                        listBox3.DataSource = rezervacije;
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

        private void UnesiKor_Click(object sender, EventArgs e)
        {
            if (textKorIme.Text != "" && textKorPrezime.Text != "" && textKorKor.Text != "" && textKorSifra.Text != "" && comboBox1.Text != "")
            {
                if (!textKorIme.Text.Any(char.IsDigit) && !textKorIme.Text.Any(char.IsDigit))
                {
                    Korisnik k = new Korisnik();
                    string putanja = "korisnici.txt";
                    List<string> linije = File.ReadAllLines(putanja).ToList();
                    ik = 1;
                    foreach (var red in linije)
                    {
                        string[] celo = red.Split(',');

                        if (ik.ToString() == celo[0])
                        {

                            ik++;

                        }
                    }

                    string borivoje = (ik) + "," + textKorIme.Text + "," + textKorPrezime.Text + "," + textKorKor.Text + "," + textKorSifra.Text + "," + comboBox1.Text + Environment.NewLine;

                    File.AppendAllText(putanja, borivoje);
                    k.Id = ik;
                    k.Ime = textKorIme.Text;
                    k.Prezime = textKorPrezime.Text;
                    k.Username = textKorKor.Text;
                    k.Password = textKorSifra.Text;
                    k.Pozicija = comboBox1.Text;
                    korisnici.Add(k);
                    listBox4.DataSource = null;
                    listBox4.DataSource = korisnici;
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BrisiKor_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                int ajdi = int.Parse(textID.Text);
                int i = 0;
                int pom = 0;
                string putanja = "korisnici.txt";
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
                if (pom == 1)
                {
                    linije.RemoveAt(brlinije - 1);
                    korisnici.RemoveAt(brlinije - 1);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        string[] drakce = linije[i].Split(',');
                        linije[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5];
                    }
                    File.WriteAllLines(putanja, linije);
                    for (i = brlinije - 1; i < linije.Count; i++)
                    {
                        korisnici[i].Id = korisnici[i].Id - 1;
                    }
                    listBox4.DataSource = null;
                    listBox4.DataSource = korisnici;
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

        private void MenjajKor_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                if (textKorIme.Text != "" && textKorPrezime.Text != "" && textKorKor.Text != "" && textKorSifra.Text != "" && comboBox1.Text != "")
                {
                    if (!textKorIme.Text.Any(char.IsDigit) && !textKorIme.Text.Any(char.IsDigit))
                    {
                        int ajdi = int.Parse(textID.Text) - 1;
                        korisnici[ajdi].Ime = textKorIme.Text;
                        korisnici[ajdi].Prezime = textKorPrezime.Text;
                        korisnici[ajdi].Username = textKorKor.Text;
                        korisnici[ajdi].Password = textKorSifra.Text;
                        korisnici[ajdi].Pozicija = comboBox1.Text;
                        string putanja = "korisnici.txt";
                        List<string> linije = File.ReadAllLines(putanja).ToList();
                        string[] drakce = linije[ajdi].Split(',');
                        linije[ajdi] = (int.Parse(drakce[0])) + "," + textKorIme.Text + "," + textKorPrezime.Text + "," + textKorKor.Text + "," + textKorSifra.Text + "," + comboBox1.Text;
                        File.WriteAllLines(putanja, linije);
                        listBox4.DataSource = null;
                        listBox4.DataSource = korisnici;
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
            else
            {
                MessageBox.Show("Niste uneli ID");
            }

        }
    }
    }

