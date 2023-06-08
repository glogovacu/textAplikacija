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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ProjekatTVP.UI_Elements
{
    public partial class CurvedTextBox : UserControl
    {
        public CurvedTextBox()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            {
                int curveSize = 60; // Adjust the curve size as desired
                int borderOffset = 2; // Adjust the border offset as desired

                path.AddArc(new Rectangle(0, 0, curveSize, curveSize), 180, 90);
                path.AddArc(new Rectangle(this.Width - curveSize, 0, curveSize, curveSize), -90, 90);
                path.AddArc(new Rectangle(this.Width - curveSize, this.Height - curveSize, curveSize, curveSize), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - curveSize, curveSize, curveSize), 90, 90);

                this.Region = new Region(path);
                using (Pen borderPen = new Pen(Color.Gray, borderOffset))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }
        [Category("CurvedTextBox")]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public override Color ForeColor
        {
            get { return textBox1.ForeColor; }
            set { textBox1.ForeColor = value; }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.OnEnter(e);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.OnLeave(e);
        }
    }
}
