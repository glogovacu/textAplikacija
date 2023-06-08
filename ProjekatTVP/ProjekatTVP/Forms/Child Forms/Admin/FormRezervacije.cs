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
    public partial class FormRezervacije : Form
    {
        public FormRezervacije()
        {
            InitializeComponent();
        }
        private void FormRezervacije_Load(object sender, EventArgs e)
        {
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
        }
        private void btnUnesiRez_Click(object sender, EventArgs e)
        {
            if (txtRezervacijeIDSobe.Text == "" || txtRezervacijeIDGosta.Text == "" || txtRezervacijeTip.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtRezervacijeIDSobe.Text.All(Char.IsDigit) || !txtRezervacijeIDGosta.Text.All(Char.IsDigit) || txtRezervacijeTip.Text.Any(char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }
            if (int.Parse(txtRezervacijeIDSobe.Text) > FileStorage.ListSobe.Count || int.Parse(txtRezervacijeIDGosta.Text) > FileStorage.ListGosti.Count)
            {
                PovratneInformacije.IDSobeIliGostaNePostoji();
                return;
            }
            if (dateRezervacijeDatumDo.Value.Subtract(dateRezervacijeDatumOd.Value).TotalDays < FileStorage.ListSobe[int.Parse(txtRezervacijeIDSobe.Text) - 1].Mindana)
            {
                PovratneInformacije.MinimalniBrojSobaJeUProblemu();
                return;
            }

            FileWriter.FileRezervacije(int.Parse(txtRezervacijeIDSobe.Text), int.Parse(txtRezervacijeIDGosta.Text), dateRezervacijeDatumOd.Value, dateRezervacijeDatumDo.Value, txtRezervacijeTip.Text);

            lbxRezervacije.DataSource = null;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
            PovratneInformacije.UspesnoJeUradjeno();
        }

        private void btnBrisiRez_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListRezervacije))
            {
                return;
            }

            FileRemover.FileRezervacije(int.Parse(txtID.Text));

            lbxRezervacije.DataSource = null;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
            PovratneInformacije.UspesnoJeUradjeno();
        }
        private void btnMenjajRez_Click(object sender, EventArgs e)
        {
            if (ProveriID(FileStorage.ListRezervacije))
            {
                return;
            }
            if (txtRezervacijeIDSobe.Text == "" || txtRezervacijeIDGosta.Text == "" || txtRezervacijeTip.Text == "")
            {
                PovratneInformacije.OstaviliStePraznaPolja();
                return;
            }
            if (!txtRezervacijeIDSobe.Text.All(Char.IsDigit) || !txtRezervacijeIDGosta.Text.All(Char.IsDigit) || txtRezervacijeTip.Text.Any(char.IsDigit))
            {
                PovratneInformacije.NekaPoljaNisuDobra();
                return;
            }
            if (int.Parse(txtRezervacijeIDSobe.Text) > FileStorage.ListSobe.Count || int.Parse(txtRezervacijeIDGosta.Text) > FileStorage.ListGosti.Count)
            {
                PovratneInformacije.IDSobeIliGostaNePostoji();
                return;
            }
            if (dateRezervacijeDatumDo.Value.Subtract(dateRezervacijeDatumOd.Value).TotalDays < FileStorage.ListSobe[int.Parse(txtRezervacijeIDSobe.Text) - 1].Mindana)
            {
                PovratneInformacije.MinimalniBrojSobaJeUProblemu();
                return;
            }

            FileChanger.FileRezervacije(int.Parse(txtID.Text) - 1, int.Parse(txtRezervacijeIDGosta.Text), int.Parse(txtRezervacijeIDSobe.Text), dateRezervacijeDatumOd.Value, dateRezervacijeDatumDo.Value, txtRezervacijeTip.Text);

            lbxRezervacije.DataSource = null;
            lbxRezervacije.DataSource = FileStorage.ListRezervacije;
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
