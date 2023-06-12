using ProjekatTVP.DataKlase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    public partial class FormSoba : GradientForm
    {
        public FormSoba()
        {
            InitializeComponent();
        }
        private void FormSoba_Load(object sender, EventArgs e)
        {
            lbxSoba.DataSource = FileStorage.ListSobe;
            lbxSoba.HorizontalScrollbar = true;
            lbxSoba.UseTabStops = true;
            // Make sure no items are displayed partially.
            lbxSoba.IntegralHeight = true;

            // Display a horizontal scroll bar.
            lbxSoba.HorizontalScrollbar = true;

            // Create a Graphics object to use when determining the size of the largest item in the ListBox.
            Graphics g = lbxSoba.CreateGraphics();

            // Determine the size for HorizontalExtent using the MeasureString method using the last item in the list.
            int hzSize = (int)g.MeasureString(lbxSoba.Items[lbxSoba.Items.Count - 1].ToString(), lbxSoba.Font).Width + 120;
            // Set the HorizontalExtent property.
            lbxSoba.HorizontalExtent = hzSize;

        }
        private void btnUnesiSoba_Click(object sender, EventArgs e)
        {
            if (txtSobaBroj.Texts == "" || txtSobaBrojKreveta.Texts == "" || cmbSobaTip.Text == "" || txtSobaCena.Texts == "" || txtSobaPopust.Texts == "" || txtSobaMin.Texts == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtSobaBroj.Texts.All(Char.IsDigit) || !txtSobaBrojKreveta.Texts.All(Char.IsDigit) || cmbSobaTip.Text.Any(char.IsDigit) || !txtSobaCena.Texts.All(Char.IsDigit) || !txtSobaPopust.Texts.All(Char.IsDigit) || !txtSobaMin.Texts.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;

            }

            FileWriter.FileSoba(int.Parse(txtSobaBroj.Texts), int.Parse(txtSobaBrojKreveta.Texts), cmbSobaTip.Text, int.Parse(txtSobaCena.Texts), int.Parse(txtSobaPopust.Texts), int.Parse(txtSobaMin.Texts));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnBrisiSoba_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListSobe))
            {
                return;
            }

            FileRemover.FileSoba(int.Parse(txtID.Texts));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
            PovratneInformacije.UspesnoJeUradjeno();

        }

        private void MenjajSoba_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListSobe))
            {
                return;
            }
            if (txtSobaBroj.Texts == "" || txtSobaBrojKreveta.Texts == "" || cmbSobaTip.Text == "" || txtSobaCena.Texts == "" || txtSobaPopust.Texts == "" || txtSobaMin.Texts == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtSobaBroj.Texts.All(Char.IsDigit) || !txtSobaBrojKreveta.Texts.All(Char.IsDigit) || cmbSobaTip.Text.Any(char.IsDigit) || !txtSobaCena.Texts.All(Char.IsDigit) || !txtSobaPopust.Texts.All(Char.IsDigit) || !txtSobaMin.Texts.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileChanger.FileSobe(int.Parse(txtID.Texts) - 1, int.Parse(txtSobaBroj.Texts), int.Parse(txtSobaBrojKreveta.Texts), cmbSobaTip.Text, int.Parse(txtSobaCena.Texts), int.Parse(txtSobaPopust.Texts), int.Parse(txtSobaMin.Texts));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
            PovratneInformacije.UspesnoJeUradjeno();

        }
        private bool ProveriID<T>(List<T> listaZaProveru)
        {
            if (txtID.Texts == "")
            {
                PovratneInformacije.IDNijeUpisan();
                return true;
            }
            if (int.Parse(txtID.Texts) > listaZaProveru.Count)
            {
                PovratneInformacije.IDNijeLepoUpisan();
                return true;
            }
            return false;
        }

        private void lbxSoba_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Utilities.DrawNewItems(sender, e);
            }
        }
    }
}
