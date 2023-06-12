using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class Gost
    {
        private int _id;
        private string _ime;
        private string _prezime;
        private DateTime _datum;
        private string _telefon;

        public int Id { get => _id; set => _id = value; }
        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public DateTime Datum { get => _datum; set => _datum = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }

        public override string ToString()
        {
            return "ID " + _id + " Name " + _ime + " LastName " + _prezime + " DateOfBirth " + _datum.Day +"." + _datum.Month + "." + _datum.Year   + " Phone " + _telefon;
        }
    }
}
