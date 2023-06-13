using ProjekatTVP.FileManagment;
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
    public partial class FormReservations : GradientForm
    {
        public FormReservations()
        {
            InitializeComponent();
        }
        private void FormReservations_Load(object sender, EventArgs e)
        {
            lbxReservations.DataSource = FileStorage.ListReservations;
            Utilities.CreateHorizontalScrollBar(lbxReservations);
        }
        private void btnAddRes_Click(object sender, EventArgs e)
        {
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

            FileWriter.FileReservations(int.Parse(txtReservationsIdRoom.Texts), int.Parse(txtReservationsIdGuest.Texts), dateReservationsDateFrom.Value, dateReservationsDateTo.Value, txtReservationsType.Texts);

            lbxReservations.DataSource = null;
            lbxReservations.DataSource = FileStorage.ListReservations;
            Feedback.Success();
        }

        private void btnDeleteRes_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListReservations))
            {
                return;
            }

            FileRemover.FileReservations(int.Parse(txtID.Texts));

            lbxReservations.DataSource = null;
            lbxReservations.DataSource = FileStorage.ListReservations;
            Feedback.Success();
        }
        private void btnChangeRes_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListReservations))
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

            FileChanger.FileReservations(int.Parse(txtID.Texts), int.Parse(txtReservationsIdGuest.Texts), int.Parse(txtReservationsIdRoom.Texts), dateReservationsDateFrom.Value, dateReservationsDateTo.Value, txtReservationsType.Texts);

            lbxReservations.DataSource = null;
            lbxReservations.DataSource = FileStorage.ListReservations;
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
