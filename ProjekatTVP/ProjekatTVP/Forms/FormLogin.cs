using ProjekatTVP.DataKlase;
using System;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (txtKorisnickoIme.Text == "" || txtPassword.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            string user = txtKorisnickoIme.Text;
            string pass = txtPassword.Text;
            
            var povratnaInformacijaKorisnika = Utilities.VratiPovratneInformacijeZaKorisnika(user, pass);

            if (povratnaInformacijaKorisnika == null)
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            Form formToShow;

            switch (povratnaInformacijaKorisnika.Pozicija)
            {
                case "admin":
                    formToShow = new FormAdmin();
                    break;
                case "recepcionar":
                    formToShow = new FormRecepcionar();
                    break;
                default:
                    MessageBox.Show("Pozicija korisnika nije definisana");
                    return;
            }

            this.Hide();
            formToShow.ShowDialog();
            this.Close();
        }
    }
}
