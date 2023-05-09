using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.DataKlase
{
    public class FileRemover
    {
        public static void FileGost(int id)
        {
            int i;
            FileStorage.StringGosti.RemoveAt(id - 1);
            FileStorage.ListGosti.RemoveAt(id - 1);
            for (i = id - 1; i < FileStorage.StringGosti.Count; i++)
            {
                string[] drakce = FileStorage.StringGosti[i].Split(',');
                FileStorage.StringGosti[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4];
            }
            File.WriteAllLines(Putanje.Gosti, FileStorage.StringGosti);
            for (i = id - 1; i < FileStorage.ListGosti.Count; i++)
            {
                FileStorage.ListGosti[i].Id = FileStorage.ListGosti[i].Id - 1;
            }
        }
        public static void FileSoba(int id)
        {
            int i;
            FileStorage.StringSobe.RemoveAt(id - 1);
            FileStorage.ListSobe.RemoveAt(id - 1);
            for (i = id - 1; i < FileStorage.StringSobe.Count; i++)
            {
                string[] drakce = FileStorage.StringSobe[i].Split(',');
                FileStorage.StringSobe[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5] + "," + drakce[6];
            }
            File.WriteAllLines(Putanje.Sobe, FileStorage.StringSobe);
            for (i = id - 1; i < FileStorage.StringSobe.Count; i++)
            {
                FileStorage.ListSobe[i].Id = FileStorage.ListSobe[i].Id - 1;
            }
            
        }
        public static void FileRezervacije(int id)
        {
            int i;
            FileStorage.StringRezervacije.RemoveAt(id - 1);
            FileStorage.ListRezervacije.RemoveAt(id - 1);
            for (i = id - 1; i < FileStorage.StringRezervacije.Count; i++)
            {
                string[] drakce = FileStorage.StringRezervacije[i].Split(',');
                FileStorage.StringRezervacije[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5] + "," + drakce[6];
            }
            File.WriteAllLines(Putanje.Rezervacije, FileStorage.StringRezervacije);
            for (i = id - 1; i < FileStorage.StringRezervacije.Count; i++)
            {
                FileStorage.ListRezervacije[i].Id = FileStorage.ListRezervacije[i].Id - 1;
            }
        }
        public static void FileKorisnici(int id)
        {
            int i;
            FileStorage.StringKorisnici.RemoveAt(id - 1);
            FileStorage.ListKorisnici.RemoveAt(id - 1);
            for (i = id - 1; i < FileStorage.StringKorisnici.Count; i++)
            {
                string[] drakce = FileStorage.StringKorisnici[i].Split(',');
                FileStorage.StringKorisnici[i] = (int.Parse(drakce[0]) - 1) + "," + drakce[1] + "," + drakce[2] + "," + drakce[3] + "," + drakce[4] + "," + drakce[5];
            }
            File.WriteAllLines(Putanje.Korisnici, FileStorage.StringKorisnici);
            for (i = id - 1; i < FileStorage.StringKorisnici.Count; i++)
            {
                FileStorage.ListKorisnici[i].Id = FileStorage.ListKorisnici[i].Id - 1;
            }
        }
    }
}
