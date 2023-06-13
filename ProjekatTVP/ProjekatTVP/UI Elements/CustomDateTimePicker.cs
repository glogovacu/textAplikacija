using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomControls.RJControls
{
    public class CustomDateTimePicker : DateTimePicker
    {
        private Color _backColor = Color.Wheat;
        private Color _foreColor = Color.White;
        private Color _borderColor = Color.MediumPurple;
        private int _borderSize = 0;

        private bool _droppedDown = false;
        private Image _calendarIcon = ProjekatTVP.Properties.Resources.calendarManji;
        private RectangleF _iconButtonArea;
        private const int _calendarIconWidth = 34;
        private const int _arrowIconWidth = 17;
        public CustomDateTimePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        #region Properties
        public Color SkinColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                if (_backColor.GetBrightness() >= 0.6F)
                    _calendarIcon = ProjekatTVP.Properties.Resources.calendarManji;
                else _calendarIcon = ProjekatTVP.Properties.Resources.calendarManji;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return _foreColor; }
            set
            {
                _foreColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return _borderSize; }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }
        #endregion

        #region Overrides
        protected override void OnDropDown(EventArgs eventargs)
        {
            base.OnDropDown(eventargs);
            _droppedDown = true;
        }
        protected override void OnCloseUp(EventArgs eventargs)
        {
            base.OnCloseUp(eventargs);
            _droppedDown = false;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (Graphics graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            using (SolidBrush skinBrush = new SolidBrush(_backColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(_foreColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                RectangleF iconArea = new RectangleF(clientArea.Width - _calendarIconWidth, 0, _calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                graphics.FillRectangle(skinBrush, clientArea);

                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                if (_droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                if (_borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                graphics.DrawImage(_calendarIcon, this.Width - _calendarIcon.Width - 9, (this.Height - _calendarIcon.Height) / 2);

            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            _iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_iconButtonArea.Contains(e.Location))
                this.Cursor = Cursors.Hand;
            else this.Cursor = Cursors.Default;
        }
        #endregion

        #region Private Methods
        private int GetIconButtonWidth()
        {
            int textWidh = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if (textWidh <= this.Width - (_calendarIconWidth + 20))
                return _calendarIconWidth;
            else return _arrowIconWidth;
        }
        #endregion
    }
}
