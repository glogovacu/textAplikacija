using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.DataKlase
{
    public class PovratneInformacije
    {
        public static void OstaviliStePraznaPolja()
        {
            MessageBox.Show("Neka polja su prazna");
        }
        public static void NekaPoljaNisuDobra()
        {
            MessageBox.Show("Niste uneli kako treba");
        }
        public static void UspesnoJeUradjeno()
        {
            MessageBox.Show("Uspesno ste uradili radnju");
        }
        public static void IDNijeUpisan()
        {
            MessageBox.Show("Niste uneli ID");
        }
        public static void IDNijeLepoUpisan()
        {
            MessageBox.Show("Taj ID ne postoji");
        }
        public static void IDSobeIliGostaNePostoji()
        {
            MessageBox.Show("ID Sobe ili ID Gosta ne postoji.");
        }
        public static void MinimalniBrojSobaJeUProblemu()
        {
            MessageBox.Show("Za datu sobu uslov nije ispunjen(minimalni broj soba).");
        }
        public static void StandardIliLuxNijeNapisan()
        {
            MessageBox.Show("Unesite standard ili lux");
        }
        public static void BrojKrevetaZaFiltriranjeNijeValidan()
        {
            MessageBox.Show("Unesite validan broj kreveta");
        }
    }
}
