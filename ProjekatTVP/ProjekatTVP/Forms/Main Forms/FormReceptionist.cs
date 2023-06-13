using ProjekatTVP.FileManagment;
using ProjekatTVP.Forms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjekatTVP
{
    public partial class FormReceptionist : CustomForm
    {

        public FormReceptionist()
        {
            InitializeComponent();
        }

        private void Recepcionar_Load(object sender, EventArgs e)
        {
            lbxReservations.DataSource = FileStorage.ListReservations;
            Utilities.CreateHorizontalScrollBar(lbxReservations);
        }
        private void btnDeleteReservation_Click(object sender, EventArgs e)
        {
            if (CheckID(FileStorage.ListReservations))
            {
                return;
            }

            FileRemover.FileReservations(int.Parse(txtID.Texts));

            lbxReservations.DataSource = null;
            lbxReservations.DataSource = FileStorage.ListReservations;
            Feedback.Success();
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            if (CheckID(FileStorage.ListReservations))
            {
                return;
            }
            if (txtReservationsIdRoom.Texts == "" || txtReservationsIdGuest.Texts == "" || txtReservationsType.Texts == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (!txtReservationsIdRoom.Texts.All(Char.IsDigit) || !txtReservationsIdGuest.Texts.All(Char.IsDigit) || txtReservationsType.Texts.Any(char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }
            if (int.Parse(txtReservationsIdRoom.Texts) > FileStorage.ListRoom.Count || int.Parse(txtReservationsIdGuest.Texts) > FileStorage.ListGuest.Count)
            {
                Feedback.IDRoomOrGuestDoesntExist();
                return;
            }
            if (dateReservationsDateTo.Value.Subtract(dateReservationsDateFrom.Value).TotalDays < FileStorage.ListRoom[int.Parse(txtReservationsIdRoom.Texts) - 1].MinStayTime)
            {
                Feedback.MinStayTimeIsAProblem();
                return;
            }

            FileChanger.FileReservations(int.Parse(txtID.Texts) - 1, int.Parse(txtReservationsIdGuest.Texts), int.Parse(txtReservationsIdRoom.Texts), dateReservationsDateFrom.Value, dateReservationsDateTo.Value, txtReservationsType.Texts);

            lbxReservations.DataSource = null;
            lbxReservations.DataSource = FileStorage.ListReservations;
            Feedback.Success();
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdd dodaj = new FormAdd();
            dodaj.ShowDialog();
            this.Close();
        }
        private bool CheckID<T>(List<T> listForChecking)
        {
            if (txtID.Texts == "")
            {
                Feedback.IDFIeldIsEmpty();
                return true;
            }
            if (int.Parse(txtID.Texts) > listForChecking.Count)
            {
                Feedback.IDDoesNotExist();
                return true;
            }
            return false;
        }
    }
}
