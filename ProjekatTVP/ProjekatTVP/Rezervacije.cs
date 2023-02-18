using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    class Rezervacije
    {
        int id;
        int idsobe;
        int idgosta;
        DateTime datumod;
        DateTime datumdo;
        int cena;
        string tip;

        public int Id { get => id; set => id = value; }
        public int Idsobe { get => idsobe; set => idsobe = value; }
        public int Idgosta { get => idgosta; set => idgosta = value; }
        public DateTime Datumod { get => datumod; set => datumod = value; }
        public DateTime Datumdo { get => datumdo; set => datumdo = value; }
        public int Cena { get => cena; set => cena = value; }
        public string Tip { get => tip; set => tip = value; }

        public override string ToString()
        {
            return "ID: " + id + " ID Sobe: " + idsobe + " ID Gosta: " + idgosta + " Datum od: " + datumod.Day + "." + datumod.Month + "." + datumod.Year + "." + " Datumdo: " + datumdo.Day + "." + datumdo.Month + "." + datumdo.Year + "." + " Cena: " + cena + "$ Tip: " + tip;
        }
    }
}
