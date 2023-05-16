using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.DataKlase
{
    public class FileReader
    {
        public FileReader() {

        }
        public static List<Korisnik> ListKorisnik()
        {
            if (!File.Exists(Putanje.Korisnici))
            {
                File.Create(Putanje.Korisnici);
            }
            List<Korisnik> korisnici = new List<Korisnik>(); 
            List<string> linije = File.ReadAllLines(Putanje.Korisnici).ToList();
            foreach (var red in linije)
            {
                Korisnik k = new Korisnik();
                string[] celo = red.Split(',');
                k.Id = int.Parse(celo[0].ToString());
                k.Ime = celo[1];
                k.Prezime = celo[2];
                k.Username = celo[3];
                k.Password = celo[4];
                k.Pozicija = celo[5];
                korisnici.Add(k);
                
            }
            return korisnici;
        }
        public static List<Gost> ListGost()
        {
            if (!File.Exists(Putanje.Gosti))
            {
                File.Create(Putanje.Gosti);
            }
            List<Gost> gost = new List<Gost>();
            List<string> linije = File.ReadAllLines(Putanje.Gosti).ToList();
            foreach (var red in linije)
            {
                Gost g = new Gost();
                string[] celo = red.Split(',');
                g.Id = int.Parse(celo[0].ToString());
                g.Ime = celo[1];
                g.Prezime = celo[2];
                string[] borivoje = celo[3].Split('-');
                g.Datum = new DateTime(int.Parse(borivoje[0]), int.Parse(borivoje[1]), int.Parse(borivoje[2]));
                g.Telefon = celo[4];
                gost.Add(g);
            }
            return gost;
        }
        public static List<Soba> ListSoba()
        {
            if(!File.Exists(Putanje.Sobe))
            {
                File.Create(Putanje.Sobe);
            }
            List<Soba> listaSoba = new List<Soba>();
            List<string> linije = File.ReadAllLines(Putanje.Sobe).ToList();
            foreach (var red in linije)
            {
                Soba s = new Soba();
                string[] celo = red.Split(',');
                s.Id = int.Parse(celo[0].ToString());
                s.Brsobe = int.Parse(celo[1].ToString());
                s.Brkreveta = int.Parse(celo[2].ToString());
                s.Tip = celo[3];
                s.Cena = int.Parse(celo[4].ToString());
                s.Popust = int.Parse(celo[5].ToString());
                s.Mindana = int.Parse(celo[6].ToString());
                listaSoba.Add(s);
            }
            return listaSoba;
        }
        public static List<Rezervacije> ListRezervacije() {
            if (!File.Exists(Putanje.Rezervacije))
            {
                File.Create(Putanje.Rezervacije);
            }
            List<Rezervacije> rezervacije = new List<Rezervacije>();
            List<string> linije = File.ReadAllLines(Putanje.Rezervacije).ToList();
            foreach (var red in linije)
            {
                Rezervacije r = new Rezervacije();
                string[] celo = red.Split(',');
                r.Id = int.Parse(celo[0]);
                r.Idsobe = int.Parse(celo[1]);
                r.Idgosta = int.Parse(celo[2]);
                string[] borivoje = celo[3].Split('-');
                r.Datumod = new DateTime(int.Parse(borivoje[0]), int.Parse(borivoje[1]), int.Parse(borivoje[2]));
                string[] slavoljub = celo[4].Split('-');
                r.Datumdo = new DateTime(int.Parse(slavoljub[0]), int.Parse(slavoljub[1]), int.Parse(slavoljub[2]));
                r.Cena = int.Parse(celo[5]);
                r.Tip = celo[6];
                rezervacije.Add(r);
            }
            return rezervacije;
        }
        public static List<string> StringGosti()
        {
            List<string> linije = File.ReadAllLines(Putanje.Gosti).ToList();
            return linije;
        }
        public static List<string> StringSobe()
        {
            List<string> linije = File.ReadAllLines(Putanje.Sobe).ToList();
            return linije;
        }
        public static List<string> StringRezervacije() 
        {
            List<string> linije = File.ReadAllLines(Putanje.Rezervacije).ToList();
            return linije;
        }
        public static List <string> StringKorisnici() 
        {
            List<string> linije = File.ReadAllLines(Putanje.Korisnici).ToList();
            return linije;
        }
    }
}
