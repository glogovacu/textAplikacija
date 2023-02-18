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
    public partial class Form1 : Form
    {
        List<Korisnik> korisnici;
        public Form1()
        {
            InitializeComponent();
            korisnici = new List<Korisnik>();
        }



        private void Form1_Load(object sender, EventArgs e)
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
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {

                string user = textBox1.Text;
                string pass = textBox2.Text;
                int p=0;
                foreach (Korisnik k in korisnici)
                {
                    if (k.Username.Equals(user) && k.Password.Equals(pass))
                    {
                        if (k.Pozicija == "admin")
                        {
                            this.Hide();
                            Admin admin = new Admin();
                            admin.ShowDialog();
                            this.Close();
                            p = 1;
                        }
                        if (k.Pozicija == "recepcionar")
                        {
                            this.Hide();
                            Recepcionar recepcioner = new Recepcionar();
                            recepcioner.ShowDialog();
                            this.Close();
                            p = 1;
                        }
                    }
                    
                }
                if (p != 1)
                {
                    MessageBox.Show("Niste uneli kako treba");
                }
            }
            else
            {
                MessageBox.Show("Niste uneli nista u polje");
            }
        }
    }
}
