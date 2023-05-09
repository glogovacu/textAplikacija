using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class Rezervacije
    {
        private int _id;
        private int _idsobe;
        private int _idgosta;
        private DateTime _datumod;
        private DateTime _datumdo;
        private int _cena;
        private string _tip;

        public int Id { get => _id; set => _id = value; }
        public int Idsobe { get => _idsobe; set => _idsobe = value; }
        public int Idgosta { get => _idgosta; set => _idgosta = value; }
        public DateTime Datumod { get => _datumod; set => _datumod = value; }
        public DateTime Datumdo { get => _datumdo; set => _datumdo = value; }
        public int Cena { get => _cena; set => _cena = value; }
        public string Tip { get => _tip; set => _tip = value; }

        public override string ToString()
        {
            return "ID: " + _id + " ID Sobe: " + _idsobe + " ID Gosta: " + _idgosta + " Datum od: " + _datumod.Day + "." + _datumod.Month + "." + _datumod.Year + "." + " Datumdo: " + _datumdo.Day + "." + _datumdo.Month + "." + _datumdo.Year + "." + " Cena: " + _cena + "$ Tip: " + _tip;
        }
    }
}
