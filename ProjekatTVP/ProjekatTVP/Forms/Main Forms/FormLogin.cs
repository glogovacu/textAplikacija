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
            txtKorisnickoIme.Text = "Username";
            txtPassword.Text = "Password";
            txtKorisnickoIme.ForeColor = Color.FromArgb(128, 128, 128);
            txtPassword.ForeColor = Color.FromArgb(128, 128, 128);
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

        private void curvedTextBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtKorisnickoIme_Enter(object sender, EventArgs e)
        {
            if(txtKorisnickoIme.Text == "Username")
            {
                txtKorisnickoIme.Text = "";
                txtKorisnickoIme.ForeColor = Color.Black;
            }
        }

        private void txtKorisnickoIme_Leave(object sender, EventArgs e)
        {
            if(txtKorisnickoIme.Text == "")
            {
                txtKorisnickoIme.Text = "Username";
                txtKorisnickoIme.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.FromArgb(128, 128, 128);
            }
        }
    }
}
