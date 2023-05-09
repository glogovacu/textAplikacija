using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatTVP.DataKlase
{
    public class FileStorage
    {
        public static List<Korisnik> ListKorisnici = FileReader.ListKorisnik();
        public static List<Gost> ListGosti = FileReader.ListGost();
        public static List<Soba> ListSobe = FileReader.ListSoba();
        public static List<Rezervacije> ListRezervacije = FileReader.ListRezervacije();
        public static List<string> StringGosti = FileReader.StringGosti();
        public static List<string> StringSobe = FileReader.StringSobe();
        public static List<string> StringRezervacije = FileReader.StringRezervacije();
        public static List<string> StringKorisnici = FileReader.StringKorisnici();
    }
}
