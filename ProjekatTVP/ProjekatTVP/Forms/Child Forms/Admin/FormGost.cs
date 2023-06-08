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
        }
        private void btnUnesiGoste_Click(object sender, EventArgs e)
        {
            if (txtGostIme.Text == "" || txtGostPrezime.Text == "" || txtGostTelefon.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtGostIme.Text.Any(char.IsDigit) || txtGostPrezime.Text.Any(char.IsDigit) || !txtGostTelefon.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileWriter.FileGost(txtGostIme.Text, txtGostPrezime.Text, dateGostDatumRodjenja.Value, txtGostTelefon.Text);

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

            FileRemover.FileGost(int.Parse(txtID.Text));

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
            if (txtGostIme.Text == "" || txtGostPrezime.Text == "" || txtGostTelefon.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (txtGostIme.Text.Any(char.IsDigit) || txtGostPrezime.Text.Any(char.IsDigit) || !txtGostTelefon.Text.All(Char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }

            FileChanger.FileGost(int.Parse(txtID.Text), txtGostIme.Text, txtGostPrezime.Text, dateGostDatumRodjenja.Value, txtGostTelefon.Text);

            lbxGost.DataSource = null;
            lbxGost.DataSource = FileStorage.ListGosti;
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
