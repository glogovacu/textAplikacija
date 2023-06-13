using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ProjekatTVP.UI_Elements
{
    public class CustomButton : System.Windows.Forms.Button
    {
        private int _borderRadius = 10;
        private int _borderSize = 2;
        private Color _borderColor = Color.White;
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(45, 30);
            this.Font = new Font("Segoe UI", 9f);
        }
        #region Properties
        public int CurveSize { get => _borderRadius; set => _borderRadius = value; }
        public int BorderOffset { get => _borderSize; set => _borderSize = value; }
        public Color BorderColor { get => _borderColor; set => _borderColor = value; }
        #endregion

        #region Overrides
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (_borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -_borderSize, -_borderSize);
                int smoothSize = _borderSize > 0 ? _borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, _borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (_borderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
            else 
            {
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }
        #endregion

        #region Private Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            pathTxt = GetFigurePath(this.ClientRectangle, _borderSize * 2);
            this.Region = new Region(pathTxt);
            pathTxt.Dispose();
        }
        #endregion
    }
}
