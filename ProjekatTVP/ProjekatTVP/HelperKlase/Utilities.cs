using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatTVP.DataKlase
{
    public class Utilities
    {
        public static Korisnik VratiPovratneInformacijeZaKorisnika(string user, string pass)
        {
            foreach (Korisnik k in FileStorage.ListKorisnici)
            {
                if (k.Username.Equals(user) && k.Password.Equals(pass))
                {
                    return k;
                }
            }
            return null;
            
        }

        
    }
}
