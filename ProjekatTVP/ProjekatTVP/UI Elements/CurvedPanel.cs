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
    public class CurvedPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the curved edges
            using (GraphicsPath path = new GraphicsPath())
            {
                int curveSize = 40; // Adjust the curve size as desired

                path.AddArc(new Rectangle(0, 0, curveSize, curveSize), 180, 90);
                path.AddArc(new Rectangle(this.Width - curveSize, 0, curveSize, curveSize), -90, 90);
                path.AddArc(new Rectangle(this.Width - curveSize, this.Height - curveSize, curveSize, curveSize), 0, 90);
                path.AddArc(new Rectangle(0, this.Height - curveSize, curveSize, curveSize), 90, 90);

                this.Region = new Region(path);
            }
        }
    }
}
