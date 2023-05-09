using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class Soba
    {
        private int _id;
        private int _brsobe;
        private int _brkreveta;
        private string _tip;
        private int _cena;
        private int _popust;
        private int _mindana;

        public int Id { get => _id; set => _id = value; }
        public int Brsobe { get => _brsobe; set => _brsobe = value; }
        public int Brkreveta { get => _brkreveta; set => _brkreveta = value; }
        public string Tip { get => _tip; set => _tip = value; }
        public int Cena { get => _cena; set => _cena = value; }
        public int Popust { get => _popust; set => _popust = value; }
        public int Mindana { get => _mindana; set => _mindana = value; }

        public override string ToString()
        {
            return "ID: " + _id + " Broj sobe: " + _brsobe + " Broj kreveta: " + _brkreveta + " Tip sobe: " + _tip + " Cena: " + _cena + "$ Popust: " + _popust + "$ Minimum dana rezervacije: " + _mindana;
        }
    }
}
