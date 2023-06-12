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
            this.BackColor = Color.Wheat;
            this.ForeColor = Color.Black;
        }

        private void LinearBackground(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Color startColor = ColorTranslator.FromHtml("#ECBC96");
            //Color endColor = ColorTranslator.FromHtml("#ECBC76");

            //LinearGradientBrush gradientBrush = new LinearGradientBrush(
            //    ClientRectangle, startColor, endColor, LinearGradientMode.BackwardDiagonal);

            //e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
        }
    }
}
