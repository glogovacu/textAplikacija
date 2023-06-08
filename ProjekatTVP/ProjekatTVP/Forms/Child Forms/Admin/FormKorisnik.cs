using ProjekatTVP.DataKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    public partial class FormKorisnik : Form
    {
        public FormKorisnik()
        {
            InitializeComponent();
        }
        private void FormKorisnik_Load(object sender, EventArgs e)
        {
            lbxKorisnik.DataSource = FileStorage.ListKorisnici;
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
