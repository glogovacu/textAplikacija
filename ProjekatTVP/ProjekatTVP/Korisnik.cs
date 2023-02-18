using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP
{
    public class Korisnik
    {
        int id;
        string ime;
        string prezime;
        string username;
        string password;
        string pozicija;

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Pozicija { get => pozicija; set => pozicija = value; }

        public override string ToString()
        {
            return "ID: "+ id + " ime: "+ ime + " prezime: "+ prezime + " korisnicko ime: " + username + " sifra: " + password + " pozicija: " + pozicija;
        }
    }
}
