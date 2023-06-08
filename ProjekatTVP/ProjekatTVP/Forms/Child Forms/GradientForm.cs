using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.Forms.Child_Forms
{
    public partial class GradientForm : Form
    {
        public GradientForm()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearBackground(e);
        }

        private void LinearBackground(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Define the start and end colors for the gradient
            Color startColor = ColorTranslator.FromHtml("#ECBC96");
            Color endColor = ColorTranslator.FromHtml("#ECBC76");

            // Create a linear gradient brush
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                ClientRectangle, startColor, endColor, LinearGradientMode.BackwardDiagonal);

            // Fill the form's background with the gradient brush
            e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
        }
    }
}
