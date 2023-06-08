using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.UI_Elements
{
    public class CurvedButton : Button
    {
        public CurvedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(45, 30); // Adjust the size as desired
            this.Font = new Font("Segoe UI", 9f);
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
                using (Pen borderPen = new Pen(Color.Black, borderOffset))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }
    }
}
