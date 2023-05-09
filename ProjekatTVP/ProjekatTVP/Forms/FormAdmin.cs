using ProjekatTVP.DataKlase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            lbxKorisnik.DataSource = FileStorage.ListKorisnici;
            lbxGost.DataSource = FileStorage.ListGosti;
            lbxSoba.DataSource = FileStorage.ListSobe;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
        }
        //dodavanje gosta
        private void btnUnesiGoste_Click(object sender, EventArgs e)
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
        //Brisanje Gosta
        private void btnBrisiGosta_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListGosti))
            {
                return;
            }

            FileRemover.FileGost(int.Parse(txtID.Text));

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
            PovratneInformacije.UspesnoJeUradjeno();

        }

        private void btnMenjajGosta_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListGosti))
            {
                return;
            }
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

            FileChanger.FileGost(int.Parse(txtID.Text), txtGostIme.Text, txtGostPrezime.Text, dateGostDatumRodjenja.Value, txtGostTelefon.Text);

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnUnesiSoba_Click(object sender, EventArgs e)
        {
            if (txtSobaBroj.Text == "" || txtSobaBrojKreveta.Text == "" || cmbSobaTip.Text == "" || txtSobaCena.Text == "" || txtSobaPopust.Text == "" || txtSobaMin.Text == "")
            { 
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtSobaBroj.Text.All(Char.IsDigit) || !txtSobaBrojKreveta.Text.All(Char.IsDigit) || cmbSobaTip.Text.Any(char.IsDigit) || !txtSobaCena.Text.All(Char.IsDigit) || !txtSobaPopust.Text.All(Char.IsDigit) || !txtSobaMin.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;

            }

            FileWriter.FileSoba(int.Parse(txtSobaBroj.Text), int.Parse(txtSobaBrojKreveta.Text), cmbSobaTip.Text, int.Parse(txtSobaCena.Text), int.Parse(txtSobaPopust.Text), int.Parse(txtSobaMin.Text));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnBrisiSoba_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListSobe))
            {
                return;
            }

            FileRemover.FileSoba(int.Parse(txtID.Text));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
            PovratneInformacije.UspesnoJeUradjeno();

        }

        private void MenjajSoba_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListSobe))
            {
                return;
            }
            if (txtSobaBroj.Text == "" || txtSobaBrojKreveta.Text == "" || cmbSobaTip.Text == "" || txtSobaCena.Text == "" || txtSobaPopust.Text == "" || txtSobaMin.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtSobaBroj.Text.All(Char.IsDigit) || !txtSobaBrojKreveta.Text.All(Char.IsDigit) || cmbSobaTip.Text.Any(char.IsDigit) || !txtSobaCena.Text.All(Char.IsDigit) || !txtSobaPopust.Text.All(Char.IsDigit) || !txtSobaMin.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileChanger.FileSobe(int.Parse(txtID.Text) - 1, int.Parse(txtSobaBroj.Text), int.Parse(txtSobaBrojKreveta.Text), cmbSobaTip.Text, int.Parse(txtSobaCena.Text), int.Parse(txtSobaPopust.Text), int.Parse(txtSobaMin.Text));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
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

        private void btnBrisiRez_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListRezervacije))
            {
                return;
            }

            FileRemover.FileRezervacije(int.Parse(txtID.Text));

            lbxRezervacije.DataSource = null;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
            PovratneInformacije.UspesnoJeUradjeno();


        }

        private void btnMenjajRez_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListRezervacije))
            {
                return;
            }
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

            FileChanger.FileRezervacije(int.Parse(txtID.Text) - 1, int.Parse(txtRezervacijeIDGosta.Text), int.Parse(txtRezervacijeIDSobe.Text), dateRezervacijeDatumOd.Value, dateRezervacijeDatumDo.Value, txtRezervacijeTip.Text);

            lbxRezervacije.DataSource = null;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnUnesiKorisnika_Click(object sender, EventArgs e)
        {
            if (txtKorisnikIme.Text == "" || txtKorisnikPrezime.Text == "" || txtKorisnikKorisnickoIme.Text == "" || txtKorisnikSifra.Text == "" || cmbKorisnikVrsta.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtKorisnikIme.Text.Any(char.IsDigit) || txtKorisnikPrezime.Text.Any(char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileWriter.FileKorisnik(txtKorisnikIme.Text, txtKorisnikPrezime.Text, txtKorisnikKorisnickoIme.Text, txtKorisnikSifra.Text, cmbKorisnikVrsta.Text);

            lbxKorisnik.DataSource = null;
            lbxKorisnik.DataSource = FileStorage.ListKorisnici;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnBrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListKorisnici))
            {
                return;
            }

            FileRemover.FileKorisnici(int.Parse(txtID.Text));
            
            lbxKorisnik.DataSource = null;
            lbxKorisnik.DataSource = FileStorage.ListKorisnici;
            PovratneInformacije.UspesnoJeUradjeno();

        }

        private void btnMenjajKorisnika_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListKorisnici))
            {
                return;
            }
            if (txtKorisnikIme.Text == "" || txtKorisnikPrezime.Text == "" || txtKorisnikKorisnickoIme.Text == "" || txtKorisnikSifra.Text == "" || cmbKorisnikVrsta.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtKorisnikIme.Text.Any(char.IsDigit) || txtKorisnikPrezime.Text.Any(char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileChanger.FileKorisnici(int.Parse(txtID.Text) - 1, txtKorisnikIme.Text, txtKorisnikPrezime.Text, txtKorisnikKorisnickoIme.Text, txtKorisnikSifra.Text, cmbKorisnikVrsta.Text);

            lbxKorisnik.DataSource = null;
            lbxKorisnik.DataSource = FileStorage.ListKorisnici;
            PovratneInformacije.UspesnoJeUradjeno();
        }
        private bool ProveriID<T>(List<T> listaZaProveru)
        {
            if (txtID.Text == "")
            {
                PovratneInformacije.IDNijeUpisan();
                return true;
            }
            if (int.Parse(txtID.Text) > listaZaProveru.Count)
            {
                PovratneInformacije.IDNijeLepoUpisan();
                return true;
            }
            return false;
        }
    }
    
}

