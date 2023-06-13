using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.FileManagment
{
    public class Utilities
    {
        public static User GetFeedbackForUser(string user, string pass)
        {
            foreach (User k in FileStorage.ListUser)
            {
                if (k.Username.Equals(user) && k.Password.Equals(pass))
                {
                    return k;
                }
            }
            return null;
        }
        public static void CreateHorizontalScrollBar(ListBox listBox)
        {
            int maxIndex = 0;
            int maxLength = 0;

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                string item = listBox.Items[i].ToString();
                int length = item.Length;

                if (length > maxLength)
                {
                    maxLength = length;
                    maxIndex = i;
                }
            }

            Font regularFont = listBox.Font;
            Font boldFont = new Font(regularFont, FontStyle.Bold);

            listBox.HorizontalScrollbar = true;
            listBox.UseTabStops = true;

            // Make sure no items are displayed partially.
            listBox.IntegralHeight = true;

            listBox.HorizontalScrollbar = true;

            // Create a Graphics object to use when determining the size of the largest item in the ListBox.
            Graphics g = listBox.CreateGraphics();

            // Determine the size for HorizontalExtent using the MeasureString method using the biggest item in the list.
            int hzSize = (int)g.MeasureString(listBox.Items[maxIndex].ToString(), boldFont).Width + 10;
            // Set the HorizontalExtent property.
            listBox.HorizontalExtent = hzSize;
        }


    }
}
