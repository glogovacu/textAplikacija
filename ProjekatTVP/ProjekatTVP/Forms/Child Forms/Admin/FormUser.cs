using ProjekatTVP.FileManagment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    public partial class FormUser : GradientForm
    {
        public FormUser()
        {
            InitializeComponent();
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            lbxUser.DataSource = FileStorage.ListUser;
            Utilities.CreateHorizontalScrollBar(lbxUser);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUserFirstName.Texts == "" || txtUserLastName.Texts == "" || txtUserUsername.Texts == "" || txtUserPassword.Texts == "" || cmbUserType.Text == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (txtUserFirstName.Texts.Any(char.IsDigit) || txtUserLastName.Texts.Any(char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }

            FileWriter.FileKorisnik(txtUserFirstName.Texts, txtUserLastName.Texts, txtUserUsername.Texts, txtUserPassword.Texts, cmbUserType.Text);

            lbxUser.DataSource = null;
            lbxUser.DataSource = FileStorage.ListUser;
            Feedback.Success();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListUser))
            {
                return;
            }

            FileRemover.FileUser(int.Parse(txtID.Texts));

            lbxUser.DataSource = null;
            lbxUser.DataSource = FileStorage.ListUser;
            Feedback.Success();

        }

        private void btnChangeUser_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListUser))
            {
                return;
            }
            if (txtUserFirstName.Texts == "" || txtUserLastName.Texts == "" || txtUserUsername.Texts == "" || txtUserPassword.Texts == "" || cmbUserType.Text == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (txtUserFirstName.Texts.Any(char.IsDigit) || txtUserLastName.Texts.Any(char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }

            FileChanger.FileUser(int.Parse(txtID.Texts), txtUserFirstName.Texts, txtUserLastName.Texts, txtUserUsername.Texts, txtUserPassword.Texts, cmbUserType.Text);

            lbxUser.DataSource = null;
            lbxUser.DataSource = FileStorage.ListUser;
            Feedback.Success();
        }
        private bool ProveriID<T>(List<T> listaZaProveru)
        {
            if (txtID.Texts == "")
            {
                Feedback.IDFIeldIsEmpty();
                return true;
            }
            if (int.Parse(txtID.Texts) > listaZaProveru.Count)
            {
                Feedback.IDDoesNotExist();
                return true;
            }
            return false;
        }

        
    }
}
