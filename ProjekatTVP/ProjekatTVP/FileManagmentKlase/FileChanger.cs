using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProjekatTVP.DataKlase
{
    public class FileChanger
    {
        public static void FileGost(int id,string ime,string prezime, DateTime datumRodjenja, string telefon)
        {
            int ajdi = id - 1;
            FileStorage.ListGosti[ajdi].Ime = ime;
            FileStorage.ListGosti[ajdi].Prezime = prezime;
            FileStorage.ListGosti[ajdi].Datum = datumRodjenja;
            FileStorage.ListGosti[ajdi].Telefon = telefon;

            string[] drakce = FileStorage.StringGosti[ajdi].Split(',');
            FileStorage.StringGosti[ajdi] = (int.Parse(drakce[0])) + "," + ime + "," + prezime + "," + datumRodjenja.ToString("yyyy/MM/dd") + "," + telefon;
            File.WriteAllLines(Putanje.Gosti, FileStorage.StringGosti);
        }
        public static void FileSobe(int id, int brSobe, int brKreveta, string tip, int cena, int popust, int minDana)
        {
            int ajdi = id;
            FileStorage.ListSobe[ajdi].Brsobe = brSobe;
            FileStorage.ListSobe[ajdi].Brkreveta = brKreveta;
            FileStorage.ListSobe[ajdi].Tip = tip;
            FileStorage.ListSobe[ajdi].Cena = cena;
            FileStorage.ListSobe[ajdi].Popust = popust;
            FileStorage.ListSobe[ajdi].Mindana = minDana;

            string[] drakce = FileStorage.StringSobe[ajdi].Split(',');
            FileStorage.StringSobe[ajdi] = (int.Parse(drakce[0])) + "," + brSobe + "," + brKreveta + "," + tip + "," + cena + "," + popust + "," + minDana;
            File.WriteAllLines(Putanje.Sobe, FileStorage.StringSobe);
        }
        public static void FileRezervacije(int id , int idGosta, int idSobe, DateTime datumOd, DateTime datumDo, string tip)
        {
            int ajdi = id;
            FileStorage.ListRezervacije[ajdi].Idgosta = idGosta;
            FileStorage.ListRezervacije[ajdi].Idsobe = idSobe;
            FileStorage.ListRezervacije[ajdi].Datumod = datumOd;
            FileStorage.ListRezervacije[ajdi].Datumdo = datumDo;
            FileStorage.ListRezervacije[ajdi].Cena = FileStorage.ListSobe[idSobe].Cena - FileStorage.ListSobe[idSobe].Popust;
            FileStorage.ListRezervacije[ajdi].Tip = tip;

            string[] drakce = FileStorage.StringRezervacije[ajdi].Split(',');
            FileStorage.StringRezervacije[ajdi] = (int.Parse(drakce[0])) + "," + idGosta + "," + idSobe + "," + datumOd.ToString("yyyy/MM/dd") + "," + datumDo.ToString("yyyy/MM/dd") + "," + (FileStorage.ListSobe[idSobe].Cena - FileStorage.ListSobe[idSobe].Popust) + "," + tip;
            File.WriteAllLines(Putanje.Rezervacije, FileStorage.StringRezervacije);
        }
        public static void FileKorisnici(int id, string ime, string prezime, string username, string password, string pozicija)
        {
            int ajdi = id;
            FileStorage.ListKorisnici[ajdi].Ime = ime;
            FileStorage.ListKorisnici[ajdi].Prezime = prezime;
            FileStorage.ListKorisnici[ajdi].Username = username;
            FileStorage.ListKorisnici[ajdi].Password = password;
            FileStorage.ListKorisnici[ajdi].Pozicija = pozicija;

            string[] drakce = FileStorage.StringKorisnici[ajdi].Split(',');
            FileStorage.StringKorisnici[ajdi] = (int.Parse(drakce[0])) + "," + ime + "," + prezime + "," + username + "," + password + "," + pozicija;
            File.WriteAllLines(Putanje.Korisnici, FileStorage.StringKorisnici);
        }
    }
}
