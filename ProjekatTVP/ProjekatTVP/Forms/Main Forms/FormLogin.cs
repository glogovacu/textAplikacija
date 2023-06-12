using ProjekatTVP.DataKlase;
using ProjekatTVP.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class FormLogin : CustomForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user = txtKorisnickoIme.Texts;
            string pass = txtPassword.Texts;
            if (user == "" || pass == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
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
