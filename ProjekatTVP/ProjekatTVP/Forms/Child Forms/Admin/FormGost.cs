using ProjekatTVP.DataKlase;
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

namespace ProjekatTVP.Forms.Child_Forms.Admin
{
    public partial class FormGost : GradientForm
    {
        public FormGost()
        {
            InitializeComponent();
        }

        private void FormGost_Load(object sender, EventArgs e)
        {
            lbxGost.DataSource = FileStorage.ListGosti;
            lbxGost.HorizontalScrollbar = true;

        }
        private void btnUnesiGoste_Click(object sender, EventArgs e)
        {
            if (txtGostIme.Texts == "" || txtGostPrezime.Texts == "" || txtGostTelefon.Texts == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtGostIme.Texts.Any(char.IsDigit) || txtGostPrezime.Texts.Any(char.IsDigit) || !txtGostTelefon.Texts.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileWriter.FileGost(txtGostIme.Texts, txtGostPrezime.Texts, dateGostDatumRodjenja.Value, txtGostTelefon.Texts);

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
            PovratneInformacije.UspesnoJeUradjeno();
        }
        //Brisanje Gosta
        private void btnBrisiGosta_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListGosti))
            {
                return;
            }

            FileRemover.FileGost(int.Parse(txtID.Texts));

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
            PovratneInformacije.UspesnoJeUradjeno();

        }

        private void btnMenjajGosta_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListGosti))
            {
                return;
            }
            if (txtGostIme.Texts == "" || txtGostPrezime.Texts == "" || txtGostTelefon.Texts == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtGostIme.Texts.Any(char.IsDigit) || txtGostPrezime.Texts.Any(char.IsDigit) || !txtGostTelefon.Texts.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileChanger.FileGost(int.Parse(txtID.Texts), txtGostIme.Texts, txtGostPrezime.Texts, dateGostDatumRodjenja.Value, txtGostTelefon.Texts);

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
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

        private void lbxGost_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Utilities.DrawNewItems(sender, e);
            }
        }
    }
}
