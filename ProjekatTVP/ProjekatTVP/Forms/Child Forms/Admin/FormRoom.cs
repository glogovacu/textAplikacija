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
    public partial class FormRoom : GradientForm
    {
        public FormRoom()
        {
            InitializeComponent();
        }
        private void FormSoba_Load(object sender, EventArgs e)
        {
            lbxRoom.DataSource = FileStorage.ListRoom;
            Utilities.CreateHorizontalScrollBar(lbxRoom);

        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNumberOfRooms.Texts == "" || txtRoomNumberOfBeds.Texts == "" || cmbRoomType.Text == "" || txtRoomPrice.Texts == "" || txtRoomDiscount.Texts == "" || txtRoomMinStayTime.Texts == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (!txtRoomNumberOfRooms.Texts.All(Char.IsDigit) || !txtRoomNumberOfBeds.Texts.All(Char.IsDigit) || cmbRoomType.Text.Any(char.IsDigit) || !txtRoomPrice.Texts.All(Char.IsDigit) || !txtRoomDiscount.Texts.All(Char.IsDigit) || !txtRoomMinStayTime.Texts.All(Char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;

            }

            FileWriter.FileRoom(int.Parse(txtRoomNumberOfRooms.Texts), int.Parse(txtRoomNumberOfBeds.Texts), cmbRoomType.Text, int.Parse(txtRoomPrice.Texts), int.Parse(txtRoomDiscount.Texts), int.Parse(txtRoomMinStayTime.Texts));

            lbxRoom.DataSource = null;
            lbxRoom.DataSource = FileStorage.ListRoom;
            Feedback.Success();
        }

        private void btnDeleteRoom_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListRoom))
            {
                return;
            }

            FileRemover.FileRoom(int.Parse(txtID.Texts));

            lbxRoom.DataSource = null;
            lbxRoom.DataSource = FileStorage.ListRoom;
            Feedback.Success();

        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListRoom))
            {
                return;
            }
            if (txtRoomNumberOfRooms.Texts == "" || txtRoomNumberOfBeds.Texts == "" || cmbRoomType.Text == "" || txtRoomPrice.Texts == "" || txtRoomDiscount.Texts == "" || txtRoomMinStayTime.Texts == "")
            {
                Feedback.SomeFieldsAreEmpty();
                return;
            }
            if (!txtRoomNumberOfRooms.Texts.All(Char.IsDigit) || !txtRoomNumberOfBeds.Texts.All(Char.IsDigit) || cmbRoomType.Text.Any(char.IsDigit) || !txtRoomPrice.Texts.All(Char.IsDigit) || !txtRoomDiscount.Texts.All(Char.IsDigit) || !txtRoomMinStayTime.Texts.All(Char.IsDigit))
            {
                Feedback.SomeFiledsAreNotGood();
                return;
            }

            FileChanger.FileRoom(int.Parse(txtID.Texts), int.Parse(txtRoomNumberOfRooms.Texts), int.Parse(txtRoomNumberOfBeds.Texts), cmbRoomType.Text, int.Parse(txtRoomPrice.Texts), int.Parse(txtRoomDiscount.Texts), int.Parse(txtRoomMinStayTime.Texts));

            lbxRoom.DataSource = null;
            lbxRoom.DataSource = FileStorage.ListRoom;
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
