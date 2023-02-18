using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    class Soba
    {
        int id;
        int brsobe;
        int brkreveta;
        string tip;
        int cena;
        int popust;
        int mindana;

        public int Id { get => id; set => id = value; }
        public int Brsobe { get => brsobe; set => brsobe = value; }
        public int Brkreveta { get => brkreveta; set => brkreveta = value; }
        public string Tip { get => tip; set => tip = value; }
        public int Cena { get => cena; set => cena = value; }
        public int Popust { get => popust; set => popust = value; }
        public int Mindana { get => mindana; set => mindana = value; }

        public override string ToString()
        {
            return "ID: " + id + " Broj sobe: " + brsobe + " Broj kreveta: " + brkreveta + " Tip sobe: " + tip + " Cena: " + cena + "$ Popust: " + popust + "$ Minimum dana rezervacije: " + mindana;
        }
    }
}
