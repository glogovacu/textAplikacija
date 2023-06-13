using System.Drawing;
using System.Windows.Forms;

namespace ProjekatTVP.UI_Elements
{
    public class CustomListBox : ListBox
    {
        public CustomListBox() 
        {
            this.DrawItem += CustomListBox_DrawItem;
        }

        #region Events

        private void CustomListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                ListBox listBox = (ListBox)sender;

                string itemText = listBox.Items[e.Index].ToString();
                string[] parts = itemText.Split('|');

                Font regularFont = e.Font;
                Font boldFont = new Font(regularFont, FontStyle.Bold);

                int xOffset = 0;
                for (int i = 0; i < parts.Length; i += 2) 
                {
                    Point drawPosition = new Point(e.Bounds.Left + xOffset, e.Bounds.Top);
                    TextRenderer.DrawText(e.Graphics, parts[i].Trim(), boldFont, drawPosition, e.ForeColor);

                    Point valuePosition = new Point(drawPosition.X + TextRenderer.MeasureText(parts[i].Trim(), boldFont).Width, drawPosition.Y);
                    TextRenderer.DrawText(e.Graphics, parts[i + 1].Trim(), regularFont, valuePosition, e.ForeColor);

                    xOffset += 5 + TextRenderer.MeasureText(parts[i].Trim() + parts[i + 1].Trim(), boldFont).Width;
                }
            }
        }
        #endregion
    }
}
