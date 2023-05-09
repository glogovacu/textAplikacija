using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.DataKlase
{
    public class FileWriter
    {
        public static void FileGost(string ime,string prezime, DateTime datumRodjenja, string brojTelefona)
        {
            Gost g = new Gost();
            g.Id = FileStorage.ListGosti.Count + 1;
            g.Ime = ime;
            g.Prezime = prezime;
            g.Datum = datumRodjenja;
            g.Telefon = brojTelefona;
            FileStorage.ListGosti.Add(g);

            string borivoje = (FileStorage.ListGosti.Count) + "," + ime + "," + prezime + "," + datumRodjenja.ToString("yyyy/MM/dd") + "," + brojTelefona + Environment.NewLine;
            File.AppendAllText(Putanje.Gosti, borivoje);
        }
        public static void FileSoba(int brSobe, int brKreveta, string tip, int cena, int popust, int minDana)
        {
            Soba s = new Soba();
            s.Id = FileStorage.ListSobe.Count+1;
            s.Brsobe = brSobe;
            s.Brkreveta = brKreveta;
            s.Tip = tip;
            s.Cena = cena;
            s.Popust = popust;
            s.Mindana = minDana;
            FileStorage.ListSobe.Add(s);

            string borivoje = (FileStorage.ListSobe.Count) + "," + brSobe + "," + brKreveta + "," + tip + "," + cena + "," + popust + "," + minDana + Environment.NewLine;
            File.AppendAllText(Putanje.Sobe, borivoje);
        }
        public static void FileRezervacije(int idSobe, int idGosta, DateTime datumOd, DateTime datumDo, string tip)
        {
            Rezervacije r = new Rezervacije();
            r.Id = FileStorage.ListRezervacije.Count + 1;
            r.Idsobe = idSobe;
            r.Idgosta = idGosta;
            r.Datumod = datumOd;
            r.Datumdo = datumDo;
            r.Cena = FileStorage.ListSobe[idSobe].Cena - FileStorage.ListSobe[idSobe].Popust;
            r.Tip = tip;
            FileStorage.ListRezervacije.Add(r);
            string borivoje = (FileStorage.ListRezervacije.Count) + "," + idSobe + "," + idGosta + "," + datumOd.ToString("yyyy/MM/dd") + "," + datumDo.ToString("yyyy/MM/dd") + "," + (FileStorage.ListSobe[idSobe].Cena - FileStorage.ListSobe[idSobe].Popust) + "," + tip + Environment.NewLine;
            File.AppendAllText(Putanje.Rezervacije, borivoje);
        }
        public static void FileKorisnik(string ime, string prezime, string username,string password, string pozicija)
        {
            Korisnik k = new Korisnik();
            k.Id = FileStorage.ListKorisnici.Count + 1;
            k.Ime = ime;
            k.Prezime = prezime;
            k.Username = username;
            k.Password = password;
            k.Pozicija = pozicija;
            FileStorage.ListKorisnici.Add(k);
            string borivoje = (FileStorage.ListKorisnici.Count) + "," + ime + "," + prezime + "," + username + "," + password + "," + pozicija + Environment.NewLine;
            File.AppendAllText(Putanje.Korisnici, borivoje);
            
        }
    }
}
