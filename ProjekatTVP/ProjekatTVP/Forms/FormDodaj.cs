using ProjekatTVP.DataKlase;
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
    public partial class FormDodaj : Form
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
        
        public FormDodaj()
        {
            InitializeComponent();
            listaGost = new List<Gost>();
            korisnici = new List<Korisnik>();
            listaSoba = new List<Soba>();
            rezervacije = new List<Rezervacije>();
            listaSoba2 = new List<Soba>();
            novasoba = new List<Soba>();
        }
        private void Dodaj_Load(object sender, EventArgs e)
        {
            lbxGost.DataSource = FileStorage.ListGosti;
            lbxSoba.DataSource = FileStorage.ListSobe;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
        }

        private void btnUnesiGosta_Click(object sender, EventArgs e)
        {
            if (txtGostIme.Text == "" || txtGostPrezime.Text == "" || txtGostTelefon.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtGostIme.Text.Any(char.IsDigit) || txtGostPrezime.Text.Any(char.IsDigit) || !txtGostTelefon.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileWriter.FileGost(txtGostIme.Text, txtGostPrezime.Text, dateGostDatumRodjenja.Value, txtGostTelefon.Text);

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnUnesiRez_Click(object sender, EventArgs e)
        {
            if (txtRezervacijeIDSobe.Text == "" || txtRezervacijeIDGosta.Text == "" || txtRezervacijeTip.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtRezervacijeIDSobe.Text.All(Char.IsDigit) || !txtRezervacijeIDGosta.Text.All(Char.IsDigit) || txtRezervacijeTip.Text.Any(char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }
            if (int.Parse(txtRezervacijeIDSobe.Text) > FileStorage.ListSobe.Count || int.Parse(txtRezervacijeIDGosta.Text) > FileStorage.ListGosti.Count)
            {
                PovratneInformacije.IDSobeIliGostaNePostoji();
                return;
            }
            if (dateRezervacijeDatumDo.Value.Subtract(dateRezervacijeDatumOd.Value).TotalDays < FileStorage.ListSobe[int.Parse(txtRezervacijeIDSobe.Text) - 1].Mindana)
            {
                PovratneInformacije.MinimalniBrojSobaJeUProblemu();
                return;
            }

            FileWriter.FileRezervacije(int.Parse(txtRezervacijeIDSobe.Text), int.Parse(txtRezervacijeIDGosta.Text), dateRezervacijeDatumOd.Value, dateRezervacijeDatumDo.Value, txtRezervacijeTip.Text);

            lbxRezervacije.DataSource = null;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnFiltrirajPoTipu_Click(object sender, EventArgs e)
        {
            if(comboBox1 == null)
            {
                PovratneInformacije.StandardIliLuxNijeNapisan();
                return;
            }
            List<Soba> tmpSoba = new List<Soba>();
            if (comboBox1.Text == "lux")
            {
                FiltriranjeZaLux(tmpSoba);
            }
            else if (comboBox1.Text == "standard")
            {
                FiltriranjeZaStandard(tmpSoba);
            }
            else
            {
                PovratneInformacije.StandardIliLuxNijeNapisan();
                return;
            }
            lbxSoba.DataSource = null;
            lbxSoba.DataSource = tmpSoba;
            tmpSoba.Clear();
            PovratneInformacije.UspesnoJeUradjeno();


        }

        private void btnFiltrirajPoBrojuKreveta_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                PovratneInformacije.BrojKrevetaZaFiltriranjeNijeValidan();
                return;
            }
            List<Soba> tmpSoba = new List<Soba>();
            for (int i = 0; i < FileStorage.ListSobe.Count; i++)
            {
                if (FileStorage.ListSobe[i].Brkreveta == numericUpDown1.Value)
                {
                    tmpSoba.Add(FileStorage.ListSobe[i]);
                }
            }
            lbxSoba.DataSource = null;
            lbxSoba.DataSource = tmpSoba;
            tmpSoba.Clear();
            PovratneInformacije.UspesnoJeUradjeno();


        }
        private void FiltriranjeZaStandard(List<Soba> tmpSoba)
        {
            for (int i = 0; i < FileStorage.ListSobe.Count; i++)
            {
                if (FileStorage.ListSobe[i].Tip == "standard")
                {
                    tmpSoba.Add(FileStorage.ListSobe[i]);
                }
            }
        }

        private void FiltriranjeZaLux(List<Soba> tmpSoba)
        {
            for (int i = 0; i < FileStorage.ListSobe.Count; i++)
            {
                if (FileStorage.ListSobe[i].Tip == "lux")
                {
                    tmpSoba.Add(FileStorage.ListSobe[i]);
                }
            }
        }
    }
}
