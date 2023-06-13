using ProjekatTVP.FileManagment;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    public partial class FormGuest : GradientForm
    {
        public FormGuest()
        {
            InitializeComponent();
        }

        private void FormGuest_Load(object sender, EventArgs e)
        {
            lbxGuest.DataSource = FileStorage.ListGuest;
            Utilities.CreateHorizontalScrollBar(lbxGuest);
        }
        // Insert the guest into the file and the list
        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (txtGuestFirstName.Texts == "" || txtGuestLastName.Texts == "" || txtGuestPhone.Texts == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (txtGuestFirstName.Texts.Any(char.IsDigit) || txtGuestLastName.Texts.Any(char.IsDigit) || !txtGuestPhone.Texts.All(Char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }

            FileWriter.FileGuest(txtGuestFirstName.Texts, txtGuestLastName.Texts, dateGuestDateOfBirth.Value, txtGuestPhone.Texts);

            lbxGuest.DataSource = null;
            lbxGuest.DataSource = FileStorage.ListGuest;
            Feedback.Success();
        }
        // Delete the guest
        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (CheckID(FileStorage.ListGuest))
            {
                return;
            }

            FileRemover.FileGuest(int.Parse(txtID.Texts));

            lbxGuest.DataSource = null;
            lbxGuest.DataSource = FileStorage.ListGuest;
            Feedback.Success();

        }
        // Change the guest
        private void btnChangeGuest_Click(object sender, EventArgs e)
        {
            if (CheckID(FileStorage.ListGuest))
            {
                return;
            }
            if (txtGuestFirstName.Texts == "" || txtGuestLastName.Texts == "" || txtGuestPhone.Texts == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (txtGuestFirstName.Texts.Any(char.IsDigit) || txtGuestLastName.Texts.Any(char.IsDigit) || !txtGuestPhone.Texts.All(Char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }

            FileChanger.FileGuest(int.Parse(txtID.Texts), txtGuestFirstName.Texts, txtGuestLastName.Texts, dateGuestDateOfBirth.Value, txtGuestPhone.Texts);

            lbxGuest.DataSource = null;
            lbxGuest.DataSource = FileStorage.ListGuest;
            Feedback.Success();
        }
        private bool CheckID<T>(List<T> listForCheckup)
        {
            if (txtID.Texts == "")
            {
                Feedback.IDFIeldIsEmpty();
                return true;
            }
            if (int.Parse(txtID.Texts) > listForCheckup.Count)
            {
                Feedback.IDDoesNotExist();
                return true;
            }
            return false;
        }
    }
}
