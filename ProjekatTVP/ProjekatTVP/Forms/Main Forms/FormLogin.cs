using ProjekatTVP.FileManagment;
using ProjekatTVP.Forms;
using System;
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
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            var feedbackForUserCredentials = Utilities.GetFeedbackForUser(user, pass);

            if (feedbackForUserCredentials == null)
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }

            Form formToShow;

            switch (feedbackForUserCredentials.Role)
            {
                case "admin":
                    formToShow = new FormAdmin();
                    break;
                case "recepcionar":
                    formToShow = new FormReceptionist();
                    break;
                default:
                    MessageBox.Show("The role is not defined for that user");
                    return;
            }

            this.Hide();
            formToShow.ShowDialog();
            this.Close();
        }
    }
}
