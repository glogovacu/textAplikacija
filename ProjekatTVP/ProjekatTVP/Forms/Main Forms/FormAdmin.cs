using ProjekatTVP.DataKlase;
using ProjekatTVP.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjekatTVP
{
    public partial class FormAdmin : CustomForm
    {
        private Form activeForm;
        private Button currentButton;
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Child_Forms.Admin.FormGost(), btnGuests);
        }
        
        private void btnGuests_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Child_Forms.Admin.FormGost(), sender);
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Child_Forms.Admin.FormSoba(), sender);
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Child_Forms.Admin.FormRezervacije(), sender);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Child_Forms.Admin.FormKorisnik(), sender);

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(226, 166, 92);
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(236, 188, 118);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define the start and end colors for the gradient
            Color startColor =  ColorTranslator.FromHtml("#ECBC96");
            Color endColor = ColorTranslator.FromHtml("#ECBC76");

            // Create a linear gradient brush
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                ClientRectangle, startColor, endColor, LinearGradientMode.BackwardDiagonal);

            // Fill the form's background with the gradient brush
            e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
        }
    }
    
}

