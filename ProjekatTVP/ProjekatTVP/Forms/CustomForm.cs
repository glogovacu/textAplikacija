using ProjekatTVP.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjekatTVP.Forms
{
    public partial class CustomForm : Form
    {
        private bool _isDragging = false;
        private Point _offset;
        private int _draggableHeight = 30; // Adjust the draggable region height as desired
        public CustomForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Button exitButton = new Button();
            Button maximizeButton = new Button();
            Button minimizeButton = new Button();

            exitButton.Image = Resources.closeManji;
            exitButton.ImageAlign = ContentAlignment.MiddleCenter;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatAppearance.MouseOverBackColor = Color.Red;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Location = new Point(1155, 0);
            exitButton.Size = new Size(45, 30);
            exitButton.Click += exitButton_Click;

            maximizeButton.Image = Resources.maximizeManji;
            maximizeButton.ImageAlign = ContentAlignment.MiddleCenter;
            maximizeButton.FlatAppearance.BorderSize = 0;
            maximizeButton.FlatStyle = FlatStyle.Flat;
            maximizeButton.Location = new Point(1110, 0);
            maximizeButton.Size = new Size(45, 30);
            maximizeButton.Click += maximizeButton_Click;

            minimizeButton.Image = Resources.MinimizeManji;
            minimizeButton.ImageAlign = ContentAlignment.MiddleCenter;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Location = new Point(1065, 0);
            minimizeButton.Size = new Size(45, 30);
            minimizeButton.Click += MinimizeButton_Click;

            this.Controls.Add(exitButton);
            this.Controls.Add(maximizeButton);
            this.Controls.Add(minimizeButton);

        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            //if(WindowState == FormWindowState.Normal)
            //{
            //    WindowState = FormWindowState.Maximized;
            //}
            //else 
            //{ 
            //    WindowState = FormWindowState.Normal;
            //}
            MessageBox.Show("This feature does not work yet");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {
            
        }
        

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Check if the left mouse button is pressed and the cursor is within the draggable region
            if (e.Button == MouseButtons.Left && e.Y < _draggableHeight)
            {
                _isDragging = true;
                _offset = new Point(e.X, e.Y);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // Reset the dragging flag when the mouse button is released
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // Check if dragging is enabled and the cursor is within the draggable region
            if (_isDragging && e.Y < _draggableHeight)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-_offset.X, -_offset.Y);
                this.Location = newLocation;
            }
        }
    }
}
