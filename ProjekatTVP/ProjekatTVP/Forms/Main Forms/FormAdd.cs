using ProjekatTVP.FileManagment;
using ProjekatTVP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class FormAdd : CustomForm
    {      
        public FormAdd()
        {
            InitializeComponent();
        }
        private void FormAdd_Load(object sender, EventArgs e)
        {
            lbxGuest.DataSource = FileStorage.ListGuest;
            lbxRoom.DataSource = FileStorage.ListRoom;
            lbxReservations.DataSource = FileStorage.ListReservations;
            Utilities.CreateHorizontalScrollBar(lbxGuest);
            Utilities.CreateHorizontalScrollBar(lbxRoom);
            Utilities.CreateHorizontalScrollBar(lbxReservations);
        }

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

        private void btnAddReservation_Click(object sender, EventArgs e)
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

        private void btnFilterByType_Click(object sender, EventArgs e)
        {
            if(comboBox1 == null)
            {
                Feedback.StandardOrLuxIsEmpty();
                return;
            }
            List<Room> tmpRoom = new List<Room>();
            if (comboBox1.Text == "lux")
            {
                FilterForLux(tmpRoom);
            }
            else if (comboBox1.Text == "standard")
            {
                FilterByStandard(tmpRoom);
            }
            else
            {
                Feedback.StandardOrLuxIsEmpty();
                return;
            }
            lbxRoom.DataSource = null;
            lbxRoom.DataSource = tmpRoom;
            tmpRoom.Clear();
            Feedback.Success();


        }

        private void btnFilterByNumberOfBeds_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                Feedback.TheNumberOfBedsForFilteringIsNotValid();
                return;
            }
            List<Room> tmpRoom = new List<Room>();
            for (int i = 0; i < FileStorage.ListRoom.Count; i++)
            {
                if (FileStorage.ListRoom[i].NumberOfBeds == numericUpDown1.Value)
                {
                    tmpRoom.Add(FileStorage.ListRoom[i]);
                }
            }
            lbxRoom.DataSource = null;
            lbxRoom.DataSource = tmpRoom;
            tmpRoom.Clear();
            Feedback.Success();


        }
        private void FilterByStandard(List<Room> tmpSoba)
        {
            for (int i = 0; i < FileStorage.ListRoom.Count; i++)
            {
                if (FileStorage.ListRoom[i].Type == "standard")
                {
                    tmpSoba.Add(FileStorage.ListRoom[i]);
                }
            }
        }

        private void FilterForLux(List<Room> tmpSoba)
        {
            for (int i = 0; i < FileStorage.ListRoom.Count; i++)
            {
                if (FileStorage.ListRoom[i].Type == "lux")
                {
                    tmpSoba.Add(FileStorage.ListRoom[i]);
                }
            }
        }
    }
}
