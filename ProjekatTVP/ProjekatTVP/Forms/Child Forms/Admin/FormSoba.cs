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
    public partial class FormSoba : Form
    {
        public FormSoba()
        {
            InitializeComponent();
            lbxSoba.DataSource = FileStorage.ListSobe;
        }
        private void btnUnesiSoba_Click(object sender, EventArgs e)
        {
            if (txtSobaBroj.Text == "" || txtSobaBrojKreveta.Text == "" || cmbSobaTip.Text == "" || txtSobaCena.Text == "" || txtSobaPopust.Text == "" || txtSobaMin.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtSobaBroj.Text.All(Char.IsDigit) || !txtSobaBrojKreveta.Text.All(Char.IsDigit) || cmbSobaTip.Text.Any(char.IsDigit) || !txtSobaCena.Text.All(Char.IsDigit) || !txtSobaPopust.Text.All(Char.IsDigit) || !txtSobaMin.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;

            }

            FileWriter.FileSoba(int.Parse(txtSobaBroj.Text), int.Parse(txtSobaBrojKreveta.Text), cmbSobaTip.Text, int.Parse(txtSobaCena.Text), int.Parse(txtSobaPopust.Text), int.Parse(txtSobaMin.Text));

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

            FileRemover.FileSoba(int.Parse(txtID.Text));

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
            if (txtSobaBroj.Text == "" || txtSobaBrojKreveta.Text == "" || cmbSobaTip.Text == "" || txtSobaCena.Text == "" || txtSobaPopust.Text == "" || txtSobaMin.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtSobaBroj.Text.All(Char.IsDigit) || !txtSobaBrojKreveta.Text.All(Char.IsDigit) || cmbSobaTip.Text.Any(char.IsDigit) || !txtSobaCena.Text.All(Char.IsDigit) || !txtSobaPopust.Text.All(Char.IsDigit) || !txtSobaMin.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileChanger.FileSobe(int.Parse(txtID.Text) - 1, int.Parse(txtSobaBroj.Text), int.Parse(txtSobaBrojKreveta.Text), cmbSobaTip.Text, int.Parse(txtSobaCena.Text), int.Parse(txtSobaPopust.Text), int.Parse(txtSobaMin.Text));

            lbxSoba.DataSource = null;
            lbxSoba.DataSource = FileStorage.ListSobe;
            PovratneInformacije.UspesnoJeUradjeno();

        }
        private bool ProveriID<T>(List<T> listaZaProveru)
        {
            if (txtID.Text == "")
            {
                PovratneInformacije.IDNijeUpisan();
                return true;
            }
            if (int.Parse(txtID.Text) > listaZaProveru.Count)
            {
                PovratneInformacije.IDNijeLepoUpisan();
                return true;
            }
            return false;
        }
    }
}
