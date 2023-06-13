using System.Drawing;
using System.Windows.Forms;

namespace ProjekatTVP.Forms.Child_Forms
{
    public partial class GradientForm : Form
    {
        public GradientForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
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
