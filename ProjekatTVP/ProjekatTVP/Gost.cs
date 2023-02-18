using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    internal class Gost
    {
        int id;
        string ime;
        string prezime;
        DateTime datum;
        string telefon;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public override string ToString()
        {
            return "ID: " + id + " Ime: " + ime + " Prezime: " + prezime + " Datum rodjenja: " + datum.Day +"." + datum.Month + "." + datum.Year   +" Broj telefona: " + telefon;
        }
    }
}
