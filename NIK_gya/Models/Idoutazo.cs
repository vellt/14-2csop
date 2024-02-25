using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIK_gya.Models
{
    // az Idoutazó táblának a reprezentálása
    // tulajdonságai karakterpontosan vannak 
    // bővítve lett kettő funckióval (TeljesNev, Eletkora)
    public class Idoutazo
    {
        public int id { get; set; }
        public string vezeteknev { get; set; }
        public string keresztnev { get; set; }
        public int neme { get; set; }
        public DateTime szuletesi_datum { get; set; }
        public string kep { get; set; }

        public string TeljesNev()
        {
            return $"{vezeteknev} {keresztnev}";
        }

        public int Eletkora(DateTime aktualisDatum)
        {
            return (int)(aktualisDatum.Subtract(szuletesi_datum).TotalDays / 365);
        }
    }
}
