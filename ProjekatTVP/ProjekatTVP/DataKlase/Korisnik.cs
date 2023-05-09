using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class Korisnik
    {
        private int _id;
        private string _ime;
        private string _prezime;
        private string _username;
        private string _password;
        private string _pozicija;

        public int Id { get => _id; set => _id = value; }
        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Pozicija { get => _pozicija; set => _pozicija = value; }

        public override string ToString()
        {
            return "ID: "+ _id + " ime: "+ _ime + " prezime: "+ _prezime + " korisnicko ime: " + _username + " sifra: " + _password + " pozicija: " + _pozicija;
        }
    }
}
